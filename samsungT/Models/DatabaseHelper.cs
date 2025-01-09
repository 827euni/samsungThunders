using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace samsungT.Models
{
    internal class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            //connectionString = "Server=DESKTOP-FB39PEA\\SQLEXPRESS;Database=samsungThunders;Integrated Security=True;"; // 집 데스크탑
            connectionString = "Server=EA-PC\\SQLEXPRESS;Database=samsungThunders;Integrated Security=True;"; // 회사 데스크탑/노트북
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
                string q = @"SET IDENTITY_INSERT Players ON;
            INSERT INTO Players (PlayerID, PlayerName, TeamID, Position, Height) VALUES (@PlayerID, @PlayerName, @TeamID, @Position, @Height);
            SET IDENTITY_INSERT Players OFF;";

                using (SqlCommand command = new SqlCommand(q, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                    command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@Position", player.Position);
                    command.Parameters.AddWithValue("@Height", player.Height);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
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
                                      ThreePoint, ThreePointA, 
                                      FreeThrow, FreeThrowA, 
                                      FieldGoal, FieldGoalA, 
                                      Assist, Score)
            VALUES (@GameID, @PlayerID, @Rebound,
                    @ThreePoint, @ThreePointA, 
                    @FreeThrow, @FreeThrowA, 
                    @FieldGoal, @FieldGoalA, 
                    @Assist, @Score)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", playerStat.GameID);
                command.Parameters.AddWithValue("@PlayerID", playerStat.PlayerID);
                command.Parameters.AddWithValue("@Rebound", playerStat.Rebound);
                command.Parameters.AddWithValue("@ThreePoint", playerStat.ThreePoint);
                command.Parameters.AddWithValue("@ThreePointA", playerStat.ThreePointA);
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
                        ThreePoint = (int)reader["ThreePoint"],
                        ThreePointA = (int)reader["ThreePointA"],
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

        public string GetCityName(int teamID)
        {
            string city = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT City FROM Teams WHERE TeamID = @TeamID";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.Parameters.AddWithValue("@TeamID", teamID);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        city = result.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"팀 이름을 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return city;
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

        public Game GetRecentGame()
        {
            Game recentGame = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT TOP 1 GameID, Date, HomeTeamID, AwayTeamID, HomeScore, AwayScore FROM Games WHERE Date <= @Today ORDER BY Date DESC";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.Parameters.AddWithValue("@Today", DateTime.Now);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        recentGame = new Game
                        {
                            GameID = (int)reader["GameID"],
                            Date = (DateTime)reader["Date"],
                            HomeTeamID = (int)reader["HomeTeamID"],
                            AwayTeamID = (int)reader["AwayTeamID"],
                            HomeScore = (int)reader["HomeScore"],
                            AwayScore = (int)reader["AwayScore"]
                        };
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"최근 게임 정보를 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return recentGame;
        }

        public Game GetSearchGame(DateTime date)
        {
            Game searchGame = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string q = "SELECT GameID, HomeTeamID, AwayTeamID, HomeScore, AwayScore FROM Games WHERE CONVERT(DATE, Date) = @Date";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.Parameters.AddWithValue("@Date", date.Date);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        searchGame = new Game
                        {
                            GameID = (int)reader["GameID"],
                            HomeTeamID = (int)reader["HomeTeamID"],
                            AwayTeamID = (int)reader["AwayTeamID"],
                            HomeScore = (int)reader["HomeScore"],
                            AwayScore = (int)reader["AwayScore"]
                        };
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"최근 게임 정보를 가져오는 중 오류가 발생했습니다: {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return searchGame;
        }
        public PlayerStatus GetGamePlayer(int gameID, int playerID)
        {
            PlayerStatus searchPlayer = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string q = "SELECT Rebound, ThreePoint, ThreePointA, FreeThrow, FreeThrowA, FieldGoal, FieldGoalA, Assist, Score FROM PlayerStatus WHERE GameID = @GameID AND PlayerID = @PlayerID";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID;
                cmd.Parameters.Add("@PlayerID", SqlDbType.Int).Value = playerID;



                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    searchPlayer = new PlayerStatus
                    {
                        Rebound = (int)reader["Rebound"],
                        ThreePoint = (int)reader["ThreePoint"],
                        ThreePointA = (int)reader["ThreePointA"],
                        FreeThrow = (int)reader["FreeThrow"],
                        FreeThrowA = (int)reader["FreeThrowA"],
                        FieldGoal = (int)reader["FieldGoal"],
                        FieldGoalA = (int)reader["FieldGoalA"],
                        Assist = (int)reader["Assist"],
                        Score = (int)reader["Score"]
                    };
                }  
            }
            return searchPlayer;
        }
    }
}
