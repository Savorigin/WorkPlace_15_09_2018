namespace ConsoleApp1
{
   public interface IFigureFactory
    {
        AbstractFigure GetFigure(int n);
        AbstractFigure RandFigure();
    }
}