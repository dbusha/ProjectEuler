namespace ProjectEuler
{
    public interface IRunProblem<out T>
    {
        T Run(int solutionNumber);
        T Run();
    }


    
    public abstract class RunProblem<T> : IRunProblem<T>
    {
        public abstract T Run(int solutionNumber);

        public T Run() => Run(1);
    }

}