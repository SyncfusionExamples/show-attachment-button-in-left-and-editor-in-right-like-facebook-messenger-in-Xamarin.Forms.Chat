using Syncfusion.XForms.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomMessageInputView : ContentPage
    {
        public CustomMessageInputView()
        {
            InitializeComponent();
        }

        private void SendButton_Tapped(object sender, System.EventArgs e)
        {
            var message = new TextMessage();
            var grid = (sender as Image).Parent as Grid;
            var editor = (grid.Children[2] as Grid).Children[0] as ChatEditorView;
            message.Text = editor.Text;
            
            if (message.Text != "")
            {
                message.Author = viewModel.CurrentUser;
                viewModel.Messages.Add(message);

                editor.Text = "";
            }

            message = null;
            grid = null;
            editor = null;
        }
    }
}