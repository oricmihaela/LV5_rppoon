using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class Notebook
    {
        ITheme sharedTheme;
        private List<Note> notes;
        public Notebook(ITheme newTheme)
        {
            this.notes = new List<Note>();
            sharedTheme = newTheme;
        }
        public void AddNote(Note note)
        {
            note.Theme = sharedTheme;
            this.notes.Add(note);
        }
        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
