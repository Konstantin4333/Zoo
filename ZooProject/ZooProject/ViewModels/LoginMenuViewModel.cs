using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.Model;
using ZooProject.View;
using ZooProject.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace ZooProject.View_Models
{
    class LoginMenuViewModel : ViewModelBase
    {

   
        public LoginMenuViewModel()
        {
            //  ViewModelBase viewModelBase;
           // FillUsers();

        }
        public ZooDataContext dBContext = new ZooDataContext();
        private List<String> list = new List<string>();
        private string username;
        private string password;
        

        private DelegateCommand commandNext;

        private List<User> users = new List<User>();
       
        private object collection;

        /*public void FillUsers()
        {
        users = dBContext.user
                
            .Select(u => u).ToList();
            list.Add(users.ToString());

           
           


        }*/
        public User FillName()
       {
       return dBContext.user
            .Where(us => us.Name == username && us.Password == password)
           .Select(u => u).FirstOrDefault();
          




       }


        /*   public User SUser
           {
               get { return user; }
               set
               {
                   user = value;

                   OnPropertyChanged("SUser");
                   Console.WriteLine();
               }
           }*/
        /* public List<User> Users
         {
             get { return users; }
             set
             {

                 if (users != value)
                 {
                     users = value;
                     OnPropertyChanged("Users");

                 }
             }

         }*/


        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                

                OnPropertyChanged("User");

            }
        }
       
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                

                OnPropertyChanged("Password");

            }
        }


        public ICommand CommandNext
        {
            get
            {
                return commandNext ?? (commandNext = new DelegateCommand(() =>
                {


                    /* SqlConnection con = new SqlConnection(@"Data Source=KONSTANTIN_D\SQLEXPRESS;Initial Catalog=ZooData;Integrated Security=True");
                     SqlCommand cmd = new SqlCommand("select * from Users where username like @username and password = @password;");
                     cmd.Parameters.AddWithValue("@username", Username);
                     cmd.Parameters.AddWithValue("@password", Password);
                     cmd.Connection = con;
                     con.Open();

                     DataSet ds = new DataSet();
                     SqlDataAdapter da = new SqlDataAdapter(cmd);
                     da.Fill(ds);
                     con.Close();

                     bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                     if (loginSuccessful)
                     {
                         // Console.WriteLine("Success!");
                         Window window = new MainMenuWindow();
                         window.Show();
                         System.Windows.Application.Current.Windows[0].Close();
                     }
                     else
                     {
                         MessageBox.Show("Грешни данни");
                     }*/
                    /*using (ZooDataContext db = new ZooDataContext())
                    {*/
                    /*users = ((List<User>)from u in dBContext.user
                             where u.Name.Equals(username) &&
                             u.Password.Equals(password)
                             select u);*/


                    /* if(dBContext.user.ElementAt(0).Name.Equals(Username) && dBContext.user.ElementAt(0).Password.Equals(Password))
                     {
                         MessageBox.Show("Login Successful!");
                         Window window = new MainMenuWindow();
                         window.Show();
                         System.Windows.Application.Current.Windows[0].Close();
                     }
                     else
                     {
                         MessageBox.Show("Login unsuccessful, no such user!");
                     }*/

                    // }

                    /*string usernameList = list.ElementAt(0);
                    //string passwordList = list.ElementAt(1);

                    if (username.Equals(usernameList))
                    {

                    Window window = new MainMenuWindow();
                    window.Show();
                    System.Windows.Application.Current.Windows[0].Close();
                    }
                     else
                     {
                       MessageBox.Show("Грешни данни");
                     }*/

                    if (FillName()!=null)
                    {
                        Window window = new MainMenuWindow();
                        window.Show();
                        System.Windows.Application.Current.Windows[0].Close();
                    }




                    

                }));
            }
        }




    }
}
