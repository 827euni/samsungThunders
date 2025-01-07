using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samsungT.Models
{
    internal class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            //connectionString = "Server=DESKTOP-FB39PEA\\SQLEXPRESS;Database=samsungThunders;Integrated Security=True;"; // 권은아 집 데스크탑
            connectionString = "Server=EA-PC\\SQLEXPRESS;Database=samsungThunders;Integrated Security=True;"; // 권은아 회사 데스크탑/노트북
        }

        public void AddTeam(Team team)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Teams (TeamName, City) VALUES (@TeamName, @City)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeamName", team.TeamName);
                command.Parameters.AddWithValue("@City", team.City);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 선수 추가
        public void AddPlayer(Player player)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Players (PlayerName, TeamID, Position, Height) VALUES (@PlayerName, @TeamID, @Position, @Height)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                command.Parameters.AddWithValue("@TeamID", player.TeamID);
                command.Parameters.AddWithValue("@Position", player.Position);
                command.Parameters.AddWithValue("@Height", player.Height);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 경기 추가
        public void AddGame(Game game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Games (Date, HomeTeamID, AwayTeamID, HomeScore, AwayScore) VALUES (@Date, @HomeTeamID, @AwayTeamID, @HomeScore, @AwayScore)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", game.Date);
                command.Parameters.AddWithValue("@HomeTeamID", game.HomeTeamID);
                command.Parameters.AddWithValue("@AwayTeamID", game.AwayTeamID);
                command.Parameters.AddWithValue("@HomeScore", game.HomeScore);
                command.Parameters.AddWithValue("@AwayScore", game.AwayScore);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 선수 통계 추가
        public void AddPlayerStat(PlayerStatus playerStat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO PlayerStatus (GameID, PlayerID, Rebound,
                                      ThreePoints, ThreePointsA, 
                                      FreeThrow, FreeThrowA, 
                                      FieldGoal, FieldGoalA, 
                                      Assist, Score)
            VALUES (@GameID, @PlayerID, @Rebound,
                    @ThreePoints, @ThreePointsA, 
                    @FreeThrow, @FreeThrowA, 
                    @FieldGoal, @FieldGoalA, 
                    @Assist, @Score)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", playerStat.GameID);
                command.Parameters.AddWithValue("@PlayerID", playerStat.PlayerID);
                command.Parameters.AddWithValue("@Rebounds", playerStat.Rebound);
                command.Parameters.AddWithValue("@ThreePoints", playerStat.ThreePoints);
                command.Parameters.AddWithValue("@ThreePointsA", playerStat.ThreePointsA);
                command.Parameters.AddWithValue("@FreeThrow", playerStat.FreeThrow);
                command.Parameters.AddWithValue("@FreeThrowA", playerStat.FreeThrowA);
                command.Parameters.AddWithValue("@FieldGoal", playerStat.FieldGoal);
                command.Parameters.AddWithValue("@FieldGoalA", playerStat.FieldGoalA);
                command.Parameters.AddWithValue("@Assist", playerStat.Assist);
                command.Parameters.AddWithValue("@Score", playerStat.Score);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTeamWin(int teamID, bool IsWin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string q;

                if (IsWin)
                {
                    q = "UPDATE Teams SET Wins = Wins + 1 WHERE TeamID = @TeamID";
                }
                else
                {
                    q = "UPDATE Teams SET Losses = Losses + 1 WHERE TeamID = @TeamID";
                }

                SqlCommand command = new SqlCommand(q, connection);
                command.Parameters.AddWithValue("@TeamID", teamID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string q = "SELECT * FROM Players";
                SqlCommand cmd = new SqlCommand(q, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Player player = new Player
                    {
                        PlayerID = (int)reader["PlayerID"],
                        PlayerName = reader["PlayerName"].ToString(),
                        Position = reader["Position"].ToString(),
                        Height = (int)reader["Height"]
                    };

                    players.Add(player);
                }
            }

            return players;
        }

        public List<PlayerStatus> GetPlayersStatus()
        {
            List<PlayerStatus> playerStatus = new List<PlayerStatus>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string q = "SELECT * FROM PlayerStatus";
                SqlCommand cmd = new SqlCommand(q, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PlayerStatus status = new PlayerStatus
                    {
                        StatID = (int)reader["StatID"],
                        GameID = (int)reader["GameID"],
                        PlayerID = (int)reader["PlayerID"],
                        Rebound = (int)reader["Rebound"],
                        ThreePoints = (int)reader["ThreePoints"],
                        ThreePointsA = (int)reader["ThreePointsA"],
                        FreeThrow = (int)reader["FreeThrow"],
                        FreeThrowA = (int)reader["FreeThrowA"],
                        FieldGoal = (int)reader["FieldGoal"],
                        FieldGoalA = (int)reader["FieldGoalA"],
                        Assist = (int)reader["Assist"],
                        Score = (int)reader["Score"]
                    };

                    decimal threePointPer = status.Get3PointPercentage();
                    decimal freeThrowPer = status.GetFreeThrowPercentage();
                    decimal fieldGoalPer = status.GetFieldGoalPercentage();

                    playerStatus.Add(status);
                }
            }
            return playerStatus;
        }

        public List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT TeamID, TeamName, Wins, Losses FROM Teams";
                    SqlCommand cmd = new SqlCommand(q, connection);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Team team = new Team
                        {
                            TeamID = (int)reader["TeamID"],
                            TeamName = reader["TeamName"].ToString(),
                            Wins = reader["Wins"] != DBNull.Value ? (int)reader["Wins"] : 0,
                            Losses = reader["Losses"] != DBNull.Value ? (int)reader["Losses"] : 0
                        };

                        teams.Add(team);
                    }
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show($"팀 정보를 가져오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teams;

        }

        public List<Game> GetGames()
        {
            List<Game> games = new List<Game>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT GameID, Date, HomeTeamID, AwayTeamID, HomeScore, AwayScore FROM Games";
                    SqlCommand cmd = new SqlCommand(q, connection);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    {
                        Game game = new Game
                        {
                            GameID = (int)reader["GameID"],
                            Date = (DateTime)reader["Date"],
                            HomeTeamID = (int)reader["HomeTeamID"],
                            AwayTeamID = (int)reader["AwayTeamID"],
                            HomeScore = (int)reader["HomeScore"],
                            AwayScore = (int)reader["AwayScore"]
                        };

                        games.Add(game);
                    }

                }
            }

            catch (Exception e) 
            {
                MessageBox.Show($"게임 정보를 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return games;
        }

        public string GetTeamName(int teamID)
        {
            string teamName = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT TeamName FROM Teams WHERE TeamID = @TeamID";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.Parameters.AddWithValue("@TeamID", teamID);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        teamName = result.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"팀 이름을 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teamName;
        }

        public string GetPlayerName(int playerID)
        {
            string Name = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT PlayerName FROM Players WHERE PlayerID = @PlayerID";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.Parameters.AddWithValue("@PlayerID", playerID);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        Name = result.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"선수 이름을 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Name;
        }
    }
}
