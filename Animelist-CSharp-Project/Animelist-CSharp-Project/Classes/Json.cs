using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Animelist_CSharp_Project
{
    class Json
    {
        public class User
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public User() { }
            public User(string name) { this.Username = name; }
            public User(string name, string email, string password)
            {
                this.Username = name;
                this.Email = email;
                this.Password = password;
            }
        }
        public class Users
        {
            public List<User> UsersList { get; set; }

            public Users()
            {
                UsersList = new List<User>();
            }
            public void AddPerson(User personToAdd)
            {
                if (UsersList == null)
                {
                    List<User> newPerson = new List<User>();
                    newPerson.Add(personToAdd);
                    UsersList = newPerson;
                }
                else
                {
                    UsersList.Add(personToAdd);
                }
            }
            public string ToJson()
            {
                JsonSerializerOptions opt = new JsonSerializerOptions() { WriteIndented = true };
                return JsonSerializer.Serialize(this, opt);
            }
        }
        public string ToJson(User user)
        {
            JsonSerializerOptions opt = new JsonSerializerOptions() { WriteIndented = true };
            return JsonSerializer.Serialize(user, opt);
        }
        public static Users FromJson(string json)
        {
            return JsonSerializer.Deserialize<Users>(json);
        }
        public static void CheckJson()
        {
            try { Users Accounts = JsonSerializer.Deserialize<Users>(ReadJson("Users")); }
            catch
            {
                Users Accounts = new Users();
                Accounts.AddPerson(new User("Rick", "@.com", "balls"));
                WriteJson("Users", Accounts.ToJson());
            }
            try { User Loggedin = JsonSerializer.Deserialize<User>(ReadJson("LoggedIn")); }
            catch
            {
                WriteJson("Users", ToJson(new User("","","")));
            }
        }
        public static void WriteJson(string filename, string content)
        {
            try { File.WriteAllText($"../../json/{filename}.json", content); }
            catch
            {
                System.IO.Directory.CreateDirectory("../../json/");
                File.WriteAllText($"../../json/{filename}.json", content);
            }

        }
        public static string ReadJson(string filename)
        {
            string path = File.ReadAllText($"../../json/{filename}.json");
            return path;
        }
        public static void AddUserToJson(string username, string email, string password)
        {
            CheckJson();
            string json = ReadJson("Users");
            Users jsonPeople = Users.FromJson(json);
            jsonPeople.AddPerson(new User(username, email, password));
            string add = jsonPeople.ToJson();
            WriteJson("Users", add);
        }
        public static Users GetUsersList()
        {
            CheckJson();
            string json = ReadJson("Users");
            return Users.FromJson(json);
        }
        public static void SetLoggedIn()
        {
            CheckJson();
        }
    }
}
