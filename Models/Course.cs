﻿namespace Registrar;

public class Course
{
  public int Id {get;set;}
  public string Code { get; set; } = "";
  public string Title { get; set; } = "";
  public int WeeklyHours { get; set; }
  public bool isEnrolled { get; set; } = false;

}
