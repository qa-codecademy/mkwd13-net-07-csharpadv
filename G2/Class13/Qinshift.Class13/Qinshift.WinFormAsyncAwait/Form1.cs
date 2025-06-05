using Newtonsoft.Json;
using Qinshift.WinFormAsyncAwait.Models;

namespace Qinshift.WinFormAsyncAwait
{
    public partial class Form1 : Form
    {
        private string Message = "No message yet!";

        public Form1()
        {
            InitializeComponent();
            listViewTodos.View = View.Details;
            listViewTodos.Columns.Add("ID", 50);
            listViewTodos.Columns.Add("Title", 300);
            listViewTodos.Columns.Add("Completed", 80);
        }

        public void SendMessage(string message)
        {
            lblResult.Text = "";
            lblMessage.Text = "";
            lblResult.Text = "Message sent with sync!";
            Thread.Sleep(7000);
            Message = message;
        }

        public async Task SendMessageAsync(string message)
        {
            lblResult.Text = "";
            lblMessage.Text = "";

            lblResult.Text = "Message sent with async!";
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Message = message;
            });
        }

        public async Task<List<Todo?>> FetchTodosData(string url)
        {
            List<Todo?> todos = new List<Todo?>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    todos = JsonConvert
                    .DeserializeObject<List<Todo?>>
                    (content);
                }
            }
            return todos;
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage("Hello there this is sync message!");
        }

        private void btnCheckMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Message;
        }

        private void btnSendMessageAsync_Click(object sender, EventArgs e)
        {
            SendMessageAsync("This message is sent asynchronously!");
        }

        private async void btnGetUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos about to fetch");
            var todos = await FetchTodosData("https://jsonplaceholder.typicode.com/todos");
            if (todos.Count > 0)
            {
                foreach (var todo in todos)
                {
                    if (todo != null)
                    {
                        var item = new ListViewItem(todo.Id.ToString());
                        item.SubItems.Add(todo.Title);
                        item.SubItems.Add(todo.Completed ? "Yes" : "No");
                        listViewTodos.Items.Add(item);
                    }
                }
            }
        }
    }
}
