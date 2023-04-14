using BindingToObject.Models;
using System.Collections.ObjectModel;

namespace Collection_view;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Student> Students { get; set; }

    private Student _student;
    public Student Student { get => _student; set { if (_student != value) { _student = value; OnPropertyChanged("Student"); } } }



    public MainPage()
    {
        Students = new ObservableCollection<Student>();
        this.BindingContext = this;
        InitializeComponent();

    }

    private void LoadStudents()
    {
        this.Students.Clear();
        Students.Add(new() { Name = "Roni", Image = "roni.jpg", BirthDate = new DateTime(2006, 2, 19) });
        Students.Add(new() { Name = "Avital", Image = "avital.jpg", BirthDate = new DateTime(2006, 4, 28) });
        Students.Add(new() { Name = "Ofek", Image = "ofek.jpg", BirthDate = new DateTime(2006, 1, 2) });
        Students.Add(new() { Name = "Yali", Image = "yali.jpg", BirthDate = new DateTime(2006, 1, 12) });
        Students.Add(new() { Name = "Ofek Man", Image = "ofekman.jpg", BirthDate = new DateTime(2006, 3, 8) });
        Students.Add(new() { Name = "Jofir", Image = "jofir.jpg", BirthDate = new DateTime(2006, 5, 28) });
        Students.Add(new() { Name = "Omer", Image = "omer.jpg", BirthDate = new DateTime(2006, 2, 9) });
        Students.Add(new() { Name = "Aviv", Image = "aviv.jpg", BirthDate = new DateTime(2006, 5, 20) });
        Student = Students[0];
        actions.IsVisible = true;
        Load.IsVisible = false;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        LoadStudents();
    }

    private void SwipeItem_Clicked(object sender, SwipedEventArgs e)
    {
        Button b = sender as Button;
        Student s = e.Parameter as Student;
        if (b.Text == "Delete")
        {
            Students.Remove(s);
        }
        else
        {
            Students.Add(s);
        }

    }
    private void ActionButtonClicked(object sender, EventArgs e)
    {
        Button b = sender as Button;
        Student s = collection.SelectedItem as Student;
        if (b.Text == "Delete")
        {
            Students.Remove(s);
        }
        else if (b.Text == "Delete all")
        {
            Students.Clear();
            actions.IsVisible = false;
            Load.IsVisible = true;
           
        }
        else
        {
            Students.Add(s);
        }
    }
}

