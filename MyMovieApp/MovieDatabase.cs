using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyMovieApp
{
    internal class MovieDatabase
    {
        public static int UserId;
        public static String UserName;
        public static String Name;
        public static String Surname;
        public static String Email;

        public static int AdminId;
        public static String AdminUserName;
        public static String AdminName;
        public static String AdminSurname;
        public static String AdminEmail;

        //UserName
        //^: Anchors the match at the beginning of the string.
        //[a - zA - Z0 - 9_]: Allows alphanumeric characters(both uppercase and lowercase letters) and underscores.
        //{ 3,20}: Specifies that the username must be between 3 and 20 characters in length.
        //$: Anchors the match at the end of the string.

        //Password
        //(?=.*?[a-z]): Positive lookahead assertion for at least one lowercase letter.
        //(?=.*?[A-Z]): Positive lookahead assertion for at least one uppercase letter.
        //(?=.*?[0-9]): Positive lookahead assertion for at least one digit.
        // (?=.*?[#?!@$%^&*-]): Positive lookahead assertion for at least one special character.

        public static int UserRegister(string UserName, string Name, string Surname, string Email, string Password)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (UserName != "" && Name != "" && Surname != "" && Email != "" && Password != "")
                {

                    // Validate UserName
                    Regex rgxUserName = new Regex(@"^[a-zA-Z0-9_]{3,20}$");
                    if (!rgxUserName.IsMatch(UserName))
                    {
                        MessageBox.Show("Invalid Username. Username must:\n" +
                                "- Be between 3 and 20 characters.\n" +
                                "- Contain only letters (both uppercase and lowercase), digits, and underscores.");

                        return 0;
                    }

                    Regex rgxEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                    if (!rgxEmail.IsMatch(Email))
                    {
                        MessageBox.Show("Invalid Email. Email must:\n" +
                                "- Be in a valid format (e.g., user@example.com).");

                        return 0;
                    }

                    //Validate Password
                    Regex rgxPassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");

                    if (!rgxPassword.IsMatch(Password))
                    {
                        MessageBox.Show("Invalid Password. Password must:\n" +
                                "- Be between 8 and 20 characters.\n" +
                                "- Contain at least one lowercase letter.\n" +
                                "- Contain at least one uppercase letter.\n" +
                                "- Contain at least one digit.\n" +
                                "- Contain at least one special character (!@#$%^&*).");

                        return 0;
                    }

                    SqlCommand cmd = new SqlCommand("Insert into TblUser (UserName, Name, Surname, Email, Password) VALUES (@PUserName, @PName, @PSurname, @PEmail, @PPassword)", conn.connection());
                    cmd.Parameters.AddWithValue("@PUserName", UserName);
                    cmd.Parameters.AddWithValue("@PName", Name);
                    cmd.Parameters.AddWithValue("@PSurname", Surname);
                    cmd.Parameters.AddWithValue("@PEmail", Email);
                    cmd.Parameters.AddWithValue("@PPassword", Password);

                    cmd.ExecuteNonQuery();
                    conn.connection().Close();

                    MessageBox.Show("Registration completed successfully");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Please fill all areas!");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        public static bool UserSign(string _UserName, string _Password)
        {

            bool signControl = false;
            if ((_UserName != "") && (_Password != ""))
            {
                String user_pass = "";
                MySqlConnection conn = new MySqlConnection();
                //conn.ConnectionString = Veritabani.ConStr;

                try
                {
                    SqlCommand Cmd = new SqlCommand("Select Password FROM TblUser WHERE UserName='" + _UserName + "'", conn.connection());
                    user_pass = Convert.ToString(Cmd.ExecuteScalar());

                    SqlCommand Cmd2 = new SqlCommand("Select Id From TblUser WHERE UserName='" + _UserName + "'", conn.connection());
                    UserId = Convert.ToInt32(Cmd2.ExecuteScalar());
                    SqlCommand Cmd3 = new SqlCommand("Select Name From TblUser WHERE UserName='" + _UserName + "'", conn.connection());
                    Name = Convert.ToString(Cmd3.ExecuteScalar());
                    SqlCommand Cmd4 = new SqlCommand("Select Surname From TblUser WHERE UserName='" + _UserName + "'", conn.connection());
                    Surname = Convert.ToString(Cmd4.ExecuteScalar());
                    SqlCommand Cmd5 = new SqlCommand("Select Email From TblUser WHERE UserName='" + _UserName + "'", conn.connection());
                    Email = Convert.ToString(Cmd5.ExecuteScalar());

                    conn.connection().Close();
                    if (_Password == user_pass)
                    {
                        signControl = true;
                        UserName = _UserName;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or password!");
                        signControl = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid User.\n\n     PLEASE SIGN UP!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all areas!");
                signControl = false;
            }
            return signControl;
        }

        public static bool AdminSign(string _UserName, string _Password)
        {

            bool signControl = false;
            if ((_UserName != "") && (_Password != ""))
            {
                String admin_pass = "";
                MySqlConnection conn = new MySqlConnection();

                try
                {
                    SqlCommand Cmd = new SqlCommand("Select Password FROM TblAdmin WHERE UserName='" + _UserName + "'", conn.connection());
                    admin_pass = Convert.ToString(Cmd.ExecuteScalar());

                    SqlCommand Cmd2 = new SqlCommand("Select Id From TblAdmin WHERE UserName='" + _UserName + "'", conn.connection());
                    AdminId = Convert.ToInt32(Cmd2.ExecuteScalar());
                    SqlCommand Cmd3 = new SqlCommand("Select Name From TblAdmin WHERE UserName='" + _UserName + "'", conn.connection());
                    AdminName = Convert.ToString(Cmd3.ExecuteScalar());
                    SqlCommand Cmd4 = new SqlCommand("Select Surname From TblAdmin WHERE UserName='" + _UserName + "'", conn.connection());
                    AdminSurname = Convert.ToString(Cmd4.ExecuteScalar());
                    SqlCommand Cmd5 = new SqlCommand("Select Email From TblAdmin WHERE UserName='" + _UserName + "'", conn.connection());
                    AdminEmail = Convert.ToString(Cmd5.ExecuteScalar());

                    conn.connection().Close();
                    if (_Password == admin_pass)
                    {
                        signControl = true;
                        AdminUserName = _UserName;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or password!");
                        signControl = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid User.\n\n     PLEASE SIGN UP!");
                }


            }
            else
            {
                MessageBox.Show("Please fill all areas!");
                signControl = false;
            }

            return signControl;
        }


        public static DataTable top10Movie = new DataTable();

        public static DataTable Get10Movies()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT TOP 10 ROW_NUMBER() OVER (ORDER BY Mv.Rating DESC) AS Number, " +
                              "Mv.Name, Mv.MovieContent, Mv.Director, Mv.Writers, Mv.Rating, Gr.Name  'Genre'" +
                              "FROM TblMovie Mv " +
                              "LEFT OUTER JOIN TblGenre Gr " +
                              "ON Mv.GenreId = Gr.Id " +
                              "ORDER BY Mv.Rating DESC";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                top10Movie.Clear();
                da.Fill(top10Movie);
                return top10Movie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; 
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    // clean up resources that are not automatically managed by the .NET garbage collector
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable top25Movie = new DataTable();

        public static DataTable Get25Movies()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT TOP 25 ROW_NUMBER() OVER (ORDER BY Mv.Rating DESC) AS Number, " +
                              "Mv.Name, Mv.MovieContent, Mv.Director, Mv.Writers, Mv.Rating, Gr.Name  'Genre'" +
                              "FROM TblMovie Mv " +
                              "LEFT OUTER JOIN TblGenre Gr " +
                              "ON Mv.GenreId = Gr.Id " +
                              "ORDER BY Mv.Rating DESC";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                top25Movie.Clear();
                da.Fill(top25Movie);
                return top25Movie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable topAllMovie = new DataTable();

        public static DataTable GetAllMovies()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT ROW_NUMBER() OVER (ORDER BY Mv.Rating DESC) AS Number, " +
                               "Mv.Name, Mv.MovieContent, Mv.Director, Mv.Writers, Mv.Rating, Gr.Name AS Genre " +
                               "FROM TblMovie Mv " +
                               "LEFT OUTER JOIN TblGenre Gr " +
                               "ON Mv.GenreId = Gr.Id " +
                               "ORDER BY Mv.Rating DESC";



                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                topAllMovie.Clear();
                da.Fill(topAllMovie);
                return topAllMovie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }
        public static DataTable GetAllMoviesForAdmin()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT Mv.Id, Mv.Name, Mv.MovieContent, Mv.Director, Mv.Writers, Mv.Rating, Gr.Name AS Genre " +
                               "FROM TblMovie Mv " +
                               "LEFT OUTER JOIN TblGenre Gr " +
                               "ON Mv.GenreId = Gr.Id ";



                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                topAllMovie.Clear();
                da.Fill(topAllMovie);
                return topAllMovie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable moviesByGenre = new DataTable();

        public static DataTable GetMoviesByGenre(string genreName)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT ROW_NUMBER() OVER (ORDER BY Mv.Rating DESC) AS Number, " +
                              "Mv.Name, Mv.MovieContent, Mv.Director, Mv.Writers, Mv.Rating, Gr.Name  'Genre'" +
                              "FROM TblMovie Mv " +
                              "INNER JOIN TblGenre Gr " +
                              "ON Mv.GenreId = Gr.Id " +
                              "WHERE Gr.Name='" + genreName + "'";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                topAllMovie.Clear();
                da.Fill(topAllMovie);
                return topAllMovie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable GetAllMoviesNotInWatchlistAndWatched()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                // 1 means is there at least one row that satisfies these conditions
                string _sql = "SELECT Id, Name " +
                              "FROM TblMovie Mv " +
                              "WHERE NOT EXISTS (SELECT * FROM TblWatchList Wa WHERE Wa.MovieId = Mv.Id AND Wa.UserId = '" + UserId + "') "+
                              "AND NOT EXISTS (SELECT * FROM TblWatched Wd WHERE Wd.MovieId = Mv.Id AND Wd.UserId = '" + UserId + "') " +
                              "ORDER BY Mv.Name";

                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable moviesNotInWatchlist = new DataTable();
                da.Fill(moviesNotInWatchlist);
                return moviesNotInWatchlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable watchlist = new DataTable();

        public static DataTable GetWatchlist()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT ROW_NUMBER()  OVER (ORDER BY Mv.Name ) AS Number, Mv.Name " +
                              "FROM TblMovie Mv " +
                              "INNER JOIN TblWatchList Wa " +
                              "ON Wa.MovieId = Mv.Id " +
                              "INNER JOIN TblUser Us " +
                              "ON Us.Id = Wa.UserId " +
                              "WHERE Us.UserName = '" + UserName + "' "+
                              "ORDER BY Mv.Name";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                watchlist.Clear();
                da.Fill(watchlist);
                return watchlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                }
            }
        }

        public static void GetRandMovie()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.connection();

                // SQL query to get a random movie name
                string query = "SELECT TOP 1 Name FROM TblMovie ORDER BY NEWID()";
                SqlCommand command = new SqlCommand(query, conn.connection());

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string randomMovieName = result.ToString();
                    MessageBox.Show("You should watch: " + randomMovieName);
                }
                else
                {
                    MessageBox.Show("No movies found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }

        public static DataTable watchedMovies = new DataTable();

        public static DataTable GetWatchedMovies()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT ROW_NUMBER()  OVER (ORDER BY Mv.Name ) AS Number, Mv.Name, Wa.Date " +
                              "FROM TblMovie Mv " +
                              "INNER JOIN TblWatched Wa " +
                              "ON Wa.MovieId = Mv.Id " +
                              "WHERE Wa.UserId = '" + UserId + "'";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                watchedMovies.Clear();
                da.Fill(watchedMovies);
                return watchedMovies;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                }
            }
        }

        public static DataTable followingList = new DataTable();

        public static DataTable GetFollowing()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT f.Id, u.Username, u.Name, u.Surname " +
                              "FROM TblUser u JOIN TblFollow f " +
                              "ON u.Id = f.FollowingId "+
                              "WHERE f.FollowerId = '" + UserId + "'";
                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                followingList.Clear();
                da.Fill(followingList);
                return followingList;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable followerList = new DataTable();

        public static DataTable GetFollower()
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT f.Id, u.Username, u.Name, u.Surname FROM TblUser u JOIN TblFollow f ON u.Id = f.FollowerId WHERE f.FollowingId = '" + UserId + "'";
                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                followerList.Clear();
                da.Fill(followerList);
                return followerList;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable userCommentList= new DataTable();

        public static DataTable GetSelectedUserComments()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string _sql = "SELECT Cm.Id, Mv.Name AS MovieName, Cm.Comment " +
                              "FROM TblComments Cm " +
                              "INNER JOIN TblUser Us ON Us.Id = Cm.UserId " +
                              "INNER JOIN TblMovie Mv ON Mv.Id = Cm.MovieId " +
                           "WHERE Us.Id = '" + UserId + "'";



                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                userCommentList.Clear();
                da.Fill(userCommentList);
                return userCommentList;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }

        public static DataTable movieCommentList = new DataTable();

        public static DataTable GetMovieComments(int movieId)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string _sql = "SELECT Cm.Comment, Us.UserName AS UserName, Mv.Name AS MovieName " +
                              "FROM TblComments Cm " +
                              "INNER JOIN TblUser Us ON Us.Id = Cm.UserId " +
                              "INNER JOIN TblMovie Mv ON Mv.Id = Cm.MovieId " +
                              "WHERE Cm.MovieId = '" + movieId + "'";



                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                movieCommentList.Clear();
                da.Fill(movieCommentList);
                return movieCommentList;
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                    conn.connection().Dispose();
                }
            }
        }
        public static void GetUnfollowedUsers(ComboBox cmb)
        {
            
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string _sql = "SELECT u.Username FROM TblUser u  WHERE u.Id <> '" + UserId + "' " + 
                    "AND NOT EXISTS (SELECT * FROM TblFollow f WHERE f.FollowerId = '" + UserId +"' "+  "AND f.FollowingId = u.Id)";

                SqlCommand Cmd = new SqlCommand(_sql, conn.connection());

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb.Items.Add(reader[0].ToString());
                }
                conn.connection().Close();


            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public static void FollowNewUser(string followedUserName)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                string _sql = "SELECT Id FROM TblUser WHERE Username = '" + followedUserName + "' ";

                using (SqlCommand cmd = new SqlCommand(_sql, conn.connection()))
                {
                    cmd.Parameters.AddWithValue("@Username", followedUserName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int newlyFollowedUserId = Convert.ToInt32(result);

                        SqlCommand cmd2 = new SqlCommand("INSERT INTO TblFollow (FollowerId, FollowingId) VALUES (@p1, @p2)", conn.connection());

                        cmd2.Parameters.AddWithValue("@p1", UserId);
                        cmd2.Parameters.AddWithValue("@p2", newlyFollowedUserId);

                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.connection().Close();
            }
        }
       
        public static void AddtoWatchlist(int movieId)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (movieId == -1)
                {
                    MessageBox.Show("Please select movie");
                    return; // Exit the method if the movieId is invalid
                }
                // Specify the columns explicitly, excluding the identity column 'Id'
                SqlCommand cmd = new SqlCommand("INSERT INTO TblWatchList (UserId, MovieId) VALUES (@UserId, @movieId)", conn.connection());
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@movieId", movieId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }
        public static void AddtoWatched(int movieId)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {

                // Specify the columns explicitly, excluding the identity column 'Id'
                SqlCommand cmd = new SqlCommand("INSERT INTO TblWatched (UserId, MovieId, Date) VALUES (@UserId, @movieId, @Date)", conn.connection());
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@movieId", movieId);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }

        public static void DeleteFromWatchlist(int movieId)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (movieId == -1)
                {
                    MessageBox.Show("Please select movie");
                    return; // Exit the method if the movieId is invalid
                }
                SqlCommand cmd = new SqlCommand("DELETE from TblWatchList where MovieId=@p1 and UserId=@p2 ", conn.connection());
                cmd.Parameters.AddWithValue("@p1", movieId);
                cmd.Parameters.AddWithValue("@p2", UserId);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }
        public static void DeleteFromWatchedMovies(int movieId)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {

                SqlCommand cmd = new SqlCommand("DELETE from TblWatched where MovieId=@p1 and UserId=@p2 ", conn.connection());
                cmd.Parameters.AddWithValue("@p1", movieId);
                cmd.Parameters.AddWithValue("@p2", UserId);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }
       
    }
}
