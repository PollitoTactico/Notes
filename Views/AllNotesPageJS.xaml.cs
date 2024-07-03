namespace Notes.Views;

public partial class AllNotesPageJS : ContentPage
{
    public AllNotesPageJS()
    {
        InitializeComponent();

       
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }

}