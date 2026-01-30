using System;
using System.Collections;

namespace YogaMeditation;

public class MeditationCenter
{
    public int MemberID{ get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Goal{ get; set; }
    public double BMI{ get; set; }
    public static ArrayList memberList=new ArrayList();
    
   
}
