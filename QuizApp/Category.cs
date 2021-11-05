namespace QuizApp
{
    public class Category {
        private long _categoryId;
        private string _categoryName;

        public long CategoryId {
            get => _categoryId;
            set => _categoryId = value;
        }

        public string CategoryName {
            get => _categoryName;
            set => _categoryName = value;
        }
    }
}