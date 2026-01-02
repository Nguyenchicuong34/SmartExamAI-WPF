using System.Windows;
using SmartExamAI.Services;
namespace SmartExamAI
{
    public partial class MainWindow : Window
    {
        private readonly OpenAIService _aiService;

        public MainWindow()
        {
            InitializeComponent();
            _aiService = new OpenAIService();
        }

        private async void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTopic.Text))
            {
                MessageBox.Show("Vui lòng nhập chủ đề!");
                return;
            }

            btnGenerate.IsEnabled = false;
            progressBar.Visibility = Visibility.Visible;
            lblStatus.Visibility = Visibility.Visible;

            try
            {
                var questions = await _aiService.GenerateQuestionsAsync(txtTopic.Text, (int)sldCount.Value);
                if (questions != null && questions.Count > 0)
                    listQuestions.ItemsSource = questions;
                else
                    MessageBox.Show("Không tạo được câu hỏi. Kiểm tra lại API Key nhé!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                btnGenerate.IsEnabled = true;
                progressBar.Visibility = Visibility.Hidden;
                lblStatus.Visibility = Visibility.Hidden;
            }
        }
    }
}