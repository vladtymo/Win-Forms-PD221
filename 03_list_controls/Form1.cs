namespace _03_list_controls
{
    public partial class Form1 : Form
    {
        List<User> users = null;
        public Form1()
        {
            InitializeComponent();

            users = new List<User>()
            {
                new User("super@gmail.com"),
                new User("vova@ukr.net", "Volodko"),
                new User("vladtm@gmail.com", "vladnaz"),
                new User("charper@gmail.com", "csharklove"),
            };


            // --------- add items to ComboBox
            // 1 - using AddRange()
            //usersConboBox.Items.AddRange(users.ToArray());
            // 2 - using DataSourse (binding)
            usersComboBox.DataSource = users;
        }

        private void UpdateUserComboBox()
        {
            usersComboBox.DataSource = null;
            usersComboBox.DataSource = users;
        }

        private void CityShowBtnClick(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedItem != null)
                MessageBox.Show($"Your city: {cityComboBox.SelectedItem.ToString()}");
            else
                MessageBox.Show("Select city!");
        }

        private void UserShowBtnClick(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select user to show info!");
                return;
            }

            var user = usersComboBox.SelectedItem as User;

            MessageBox.Show($"User login: {user.Login}!");
        }

        private void RemoveUserBtnClick(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select user to remove!"); return;
            }

            // delete user form user collection
            users.RemoveAt(usersComboBox.SelectedIndex);

            UpdateUserComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // add new item to the user collection
            users.Add(new User("test@gmail.com"));

            UpdateUserComboBox();
        }
    }

    public class User
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; }

        public User(string email, string login = null)
        {
            CreationDate = DateTime.Now;
            Email = email;
            Login = login ?? email;
        }

        public override string ToString()
        {
            return $"{Email} : {CreationDate.ToShortTimeString()}";
        }
    }
}