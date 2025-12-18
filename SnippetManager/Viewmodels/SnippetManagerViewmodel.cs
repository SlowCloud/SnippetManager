using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SnippetManager.Models;
using CommunityToolkit.Mvvm.Input;

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

        private void LoadInitialSnippet()
        {
            SelectedSnippet = snippets[0];
        }

        [RelayCommand]
        private void LoadSnippets()
        {
            snippets.Add(new Snippet("Example Snippet 1", "This is the content of snippet 1."));
            snippets.Add(new Snippet("Example Snippet 2", "This is the content of snippet 2."));
            snippets.Add(new Snippet("Example Snippet 3", "This is the content of snippet 3."));
        }

        [RelayCommand]
        private void SelectSnippet(Snippet snippet)
        {
            SelectedSnippet = snippet;
        }
    }
}
