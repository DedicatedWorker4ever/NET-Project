public class Animal
{
    private String name;
    private String color;

    public Animal(String name, String color)
    {
        this.name = name;
        this.color = color;
    }
    public String toString()
    {
        return this.name + " " + this.color;
    }
}