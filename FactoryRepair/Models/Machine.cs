using System.Collections.Generic;

namespace FactoryRepair.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}