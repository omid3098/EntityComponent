using System.Collections.Generic;

public interface IComponent
{
    List<ISystem> systems { get; set; }
}