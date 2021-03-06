﻿namespace MinaryLib.AttackService.Interface
{
  using MinaryLib.AttackService.Class;
  using MinaryLib.AttackService.Enum;
  using System.Collections.Generic;


  public interface IAttackService
  {

    #region PROPERTIES

    string ServiceName { get; set; }

    ServiceStatus Status { get; set; }

    ServiceStartMode StartMode { get; set; }

    #endregion


    #region PUBLIC

    ServiceStatus StartService(StartServiceParameters hostParameters, Dictionary<string, List<object>> pluginsParameters);

    ServiceStatus StopService();

    void WriteTargetSystemsConfigFile(Dictionary<string, string> targetList);

    #endregion

  }
}
