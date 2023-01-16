using System.Collections.Generic;

namespace FactoryRepair.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}