using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SnippetManager.Models;
using System.Collections.ObjectModel;

namespace SnippetManager.Viewmodels
{
    public partial class SnippetManagerViewmodel : ObservableObject
    {
        private ObservableCollection<Snippet> snippets = [];

        [ObservableProperty]
        private Snippet selectedSnippet;

        public SnippetManagerViewmodel()
        {
            LoadSnippets();
            LoadInitialSnippet();
        }

        public ObservableCollection<Snippet> Snippets { get => snippets; set => snippets = value; }

        private void LoadInitialSnippet()
        {
            SelectedSnippet = Snippets[0];
        }

        [RelayCommand]
        private void LoadSnippets()
        {
            Snippets.Add(new Snippet("Example Snippet 1", "This is the content of snippet 1."));
            Snippets.Add(new Snippet("Example Snippet 2", "This is the content of snippet 2."));
            Snippets.Add(new Snippet("Example Snippet 3", "This is the content of snippet 3."));
        }

        [RelayCommand]
        private void SelectSnippet(Snippet snippet)
        {
            SelectedSnippet = snippet;
        }
    }
}
