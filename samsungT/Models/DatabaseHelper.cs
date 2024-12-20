using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.Models
{
    internal class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = "Server=DESKTOP-FB39PEA\\SQLEXPRESS;Database=samsungThunders;Integrated Security=True;";
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
                    INSERT INTO PlayerStats (GameID, PlayerID, Points, Rebounds, Assists, 
                                              ThreePointsMade, ThreePointsAttempted, 
                                              FreeThrowsMade, FreeThrowsAttempted, 
                                              TwoPointsMade, TwoPointsAttempted)
                    VALUES (@GameID, @PlayerID, @Points, @Rebounds, @Assists, 
                            @ThreePointsMade, @ThreePointsAttempted, 
                            @FreeThrowsMade, @FreeThrowsAttempted, 
                            @TwoPointsMade, @TwoPointsAttempted)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GameID", playerStat.GameID);
                command.Parameters.AddWithValue("@PlayerID", playerStat.PlayerID);
                command.Parameters.AddWithValue("@Points", playerStat.Points);
                command.Parameters.AddWithValue("@Rebounds", playerStat.Rebounds);
                command.Parameters.AddWithValue("@Assists", playerStat.Assists);
                command.Parameters.AddWithValue("@ThreePointsMade", playerStat.ThreePoints);
                command.Parameters.AddWithValue("@ThreePointsAttempted", playerStat.ThreePointsA);
                command.Parameters.AddWithValue("@FreeThrowsMade", playerStat.FreeThrow);
                command.Parameters.AddWithValue("@FreeThrowsAttempted", playerStat.FreeThrowA);
                command.Parameters.AddWithValue("@TwoPointsMade", playerStat.TwoPoints);
                command.Parameters.AddWithValue("@TwoPointsAttempted", playerStat.TwoPointsA);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 팀 스테이터스 추가
        public void AddTeamStat(TeamStatus teamStat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TeamStats (TeamID, GameID, Wins, Losses, WinRate) VALUES (@TeamID, @GameID, @Wins, @Losses, @WinRate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeamID", teamStat.TeamID);
                command.Parameters.AddWithValue("@GameID", teamStat.GameID);
                command.Parameters.AddWithValue("@Wins", teamStat.Wins);
                command.Parameters.AddWithValue("@Losses", teamStat.Losses);
                command.Parameters.AddWithValue("@WinRate", teamStat.WinRate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // 삼성과의 승률 비교
        public decimal GetWinRate(int teamID)
        {
            decimal winRate = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Wins) AS TotalWins, SUM(Losses) AS TotalLosses FROM TeamStats WHERE TeamID = @TeamID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeamID", teamID);

                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int totalWins = reader["TotalWins"] != DBNull.Value ? (int)reader["TotalWins"] : 0;
                    int totalLosses = reader["TotalLosses"] != DBNull.Value ? (int)reader["TotalLosses"] : 0;
                    int totalGames = totalWins + totalLosses;

                    if (totalGames > 0)
                    {
                        winRate = (decimal)totalWins / totalGames;
                    }
                }
            }

            return winRate;
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



    }
}
