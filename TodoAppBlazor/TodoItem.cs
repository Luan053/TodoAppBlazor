using System.ComponentModel.DataAnnotations;

namespace TodoAppBlazor
{
    public class TodoItem
    {
        public TodoItem(string text)
        {
            Text = text;
        }
        [Required (ErrorMessage = "De um nome a tarefa!")]
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}