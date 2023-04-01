namespace FC.Codeflix.Catalog.Domain.Entity;
public class Category
{
    public Guid Id { get; private set; }
    public String Name { get; private set; }
    public String Description { get; private set; }
    public Boolean IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public Category(string name, string description, bool isActive = true)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = DateTime.Now;
    }

    Validate();

    public Validate()
    {
        if (String.IsNullOrWhiteSpace)
        {
            throw new EntityValidationException($"{nameof(Name)} should not be empty or null");
        }
    }
}
