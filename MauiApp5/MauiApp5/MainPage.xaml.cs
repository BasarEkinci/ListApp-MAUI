using MauiApp5.Persons;

namespace MauiApp5;

public partial class MainPage : ContentPage
{

    List<Student> studentList = new List<Student>();

    public MainPage()
    {
        InitializeComponent();
        Student_List_View.ItemsSource = studentList;
    }

    private async void Student_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var student = e.Item as Student;

        await DisplayAlert("Selected Student", "Student Name: " + student.Department, "OK");
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        int ID;
        int.TryParse(Std_ID.Text, out ID);

        studentList.Add(new Student(Std_Name.Text,Std_Department.Text,ID));

        Std_ID.Text = "";
        Std_Name.Text = "";
        Std_Department.Text = "";

        Student_List_View.ItemsSource = null;
        Student_List_View.ItemsSource = studentList;
    }
}
