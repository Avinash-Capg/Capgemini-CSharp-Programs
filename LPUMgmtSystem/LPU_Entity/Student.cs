namespace LPU_Entity
{
    public enum CourseType
    {
        Mechanical=10,
        Electrical=20,
        Civil=30,
        CSE=40,
        IT=50
    }
    
    public class Student
    {
        public int StudentID{ get; set; }
        public string Name{ get; set; }
        public string Address { get; set; }
        public CourseType Course { get; set; } //Property of type enum
    }
}
