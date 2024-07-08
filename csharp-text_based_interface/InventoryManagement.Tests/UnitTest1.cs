namespace InventoryManagement.Tests;

public class Tests
{
    private static JsonStorage? storage;
    private User newUser;
    private Item temp;
    private Dictionary<string, object> Data = new Dictionary<string, object>();

    [SetUp]
    public void Setup()
    {
        storage = JsonStorage.Instance;

        temp = new Item("James Bond")
        {
            description = "Testing One Two",
            price = 10f
        };
        storage?.New(temp);
        storage?.New(new Item("License"));

        storage?.New(new User("JB007"));
        newUser = new User("Aston Martin")
        {
            date_created = DateTime.Now
        };

        storage?.New(newUser);

        storage?.New(new Inventory(newUser.id!, temp.id!, 20));

        storage?.Save();

        storage?.Load();
    }

    [TearDown]
    public void CleanUp()
    {
        storage?.EmptyFile();
    }

    [Test]
    public void Test_User()
    {
        User TestUser = new User("Test");

        Assert.IsTrue(TestUser.name == "Test");
    }

    [Test]
    public void Test_Item()
    {
        Item TestItem = new Item("Testing")
        {
            price = 10,
            description = "testing 2 one"
        };

        Assert.IsTrue(TestItem.name == "Testing");
        Assert.IsTrue(TestItem.price == 10);
        Assert.IsTrue(TestItem.description == "testing 2 one");
    }

    [Test]
    public void Test_Inventory()
    {
        Inventory testInventory = new Inventory(newUser.id!, temp.id!, 20);
        Assert.IsTrue(testInventory.item_id == temp.id);
        Assert.IsTrue(testInventory.user_id == newUser.id);
        Assert.IsTrue(testInventory.quantity == 20);
    }

    [Test]
    public void Test_UserAddition()
    {
        int count = storage?.All().Count ?? 0;
        Assert.IsTrue(count == 5);
    }

    [Test]
    public void Test_Adding()
    {
        User AnotherUser = new User("Testing 2 1");
        storage?.New(AnotherUser);
        storage?.Save();

        int count = storage?.All().Count ?? 0;
        Assert.IsTrue(count == 6);
    }

    [Test]
    public void Test_Deleting()
    {
        Data = storage?.All() ?? new Dictionary<string, object>();
        Data.Remove(newUser.id!);

        int count = storage?.All().Count ?? 0;
        Assert.IsTrue(count == 5);
    }
}
