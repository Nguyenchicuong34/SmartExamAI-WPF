# SmartExamAI-WPF
#  SmartExam AI - AI-Powered Exam Generator

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![WPF](https://img.shields.io/badge/WPF-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OpenAI](https://img.shields.io/badge/OpenAI-412991?style=for-the-badge&logo=openai&logoColor=white)

**SmartExam AI** is a desktop application built with **WPF (Windows Presentation Foundation)** and **C#** that leverages the power of **OpenAI API** to automatically generate multiple-choice questions based on user-provided topics.

##  Features

* **AI Question Generation:** Creates accurate multiple-choice questions from any text/topic using GPT-3.5/GPT-4.
* **Modern UI:** Beautiful interface designed with **Material Design in XAML**.
* **Instant Feedback:** View correct answers and detailed explanations for each question.
* **Customizable:** Adjustable number of questions per request.

##  Tech Stack

* **Language:** C# (.NET 6.0 / .NET 8.0)
* **Framework:** WPF (Windows Presentation Foundation)
* **UI Library:** [MaterialDesignInXamlToolkit](http://materialdesigninxaml.net/)
* **AI Service:** OpenAI REST API
* **Data Handling:** Newtonsoft.Json

## 📸 Screenshots

*(Add your screenshots here)*

##  How to Run

1.  Clone the repository:
    ```bash
    git clone [https://github.com/YOUR_USERNAME/SmartExamAI-WPF.git](https://github.com/YOUR_USERNAME/SmartExamAI-WPF.git)
    ```
2.  Open the project in **Visual Studio 2022**.
3.  Navigate to `Services/OpenAIService.cs` and replace the API Key:
    ```csharp
    private readonly string _apiKey = "gpt key 3.5 ";
    ```
4.  Build and Run (F5).

##  Author: Nguyen Chi Cuong

**Nguyen Chi Cuong**
* Major: Information Security @ HUIT
* Focus: Software Development & Network Security
