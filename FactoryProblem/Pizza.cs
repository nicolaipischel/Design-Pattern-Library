namespace SimpleFactory;
public class Pizza
{
  public virtual void Prepare() => Console.WriteLine("Pizza is being prepared");
  public virtual void Bake() => Console.WriteLine("Pizza is being baked");
  public virtual void Cut() => Console.WriteLine("Pizza is being cut into pieces");
  public virtual void Box() => Console.WriteLine("Pizza is being packaged");
}
