namespace DecoraterProblem;
public class Beverage
{
  private const double _milkPrice = .10;
  private const double _soyPrice = .15;
  private const double _mochaPrice = .20;
  private const double _whipPrice = .10;

  public bool HasMilk { get; set; }
  public bool HasSoy { get; set; }
  public bool HasMocha { get; set; }
  public bool HasWhip { get; set; }
  protected string Description { get; set; } = "Normal Coffee";

  public virtual double Cost()
  {
    var condimentCost = 0.0;

    if (HasMilk) condimentCost += _milkPrice;
    if (HasSoy) condimentCost += _soyPrice;
    if (HasMocha) condimentCost += _mochaPrice;
    if (HasWhip) condimentCost += _whipPrice;

    return condimentCost;
  }
}
