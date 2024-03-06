using System;

public class Inventory : BaseClass
{
    
    string? user_id;
    string? item_id;

    int quantity = 1;

    public Inventory(string user_id, string item_id, int quantity = 1)
    {
        this.user_id = user_id;
        this.item_id = item_id;

        if(this.quantity < 0)
        {
            this.quantity = 0;
        }
        else
        {
            this.quantity = quantity;
        }
    }

}