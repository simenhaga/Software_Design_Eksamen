namespace QuizApp
{
    public class QuizFactory : QuizDocument
    {

        public override IQuiz CreateQuiz()
        {
            var command = Command.InvalidChoice;

            while (command != Command.Quit)
            {
                command = Quiz.Menu(out string param);

                switch (command)
                {
                    case Command.InvalidChoice:
                        OutputHandler.Write("Not a valid choice");
                        break;

                    case Command.AnimalsQuiz:
                        OutputHandler.Write("You chose the animal quiz");
                        return new AnimalQuiz();

                    case Command.GameQuiz:
                        OutputHandler.Write("You chose the game quiz");
                        return new GameQuiz();

                    case Command.GeographyQuiz:
                        OutputHandler.Write("You chose the geography quiz");
                        return new GeographyQuiz();

                    case Command.CarQuiz:
                        OutputHandler.Write("You chose the car quiz");
                        return new CarQuiz();

                    case Command.MixedQuiz:
                        OutputHandler.Write("You chose the mixed quiz");
                        return new MixedQuiz();
                }
            }

            return null;
        }
    }
}