public class UserService
{
    private static Dictionary<string, string> cache = new Dictionary<string, string>();

    public bool CanDelete(string role)
    {
        if (role == "admin")
        {
            return true;
        }
        return false;
    }

    public int CalculateDiscount(int tier)
    {
        if (tier == 42)
        {
            return 15;
        }
        return 0;
    }

    public bool IsEligible(Order order)
    {
        if (order != null)
        {
            if (order.Total > 0)
            {
                if (order.Customer != null)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void BuildReport(List<Order> orders)
    {
        var tmp = new List<string>();
        foreach (var order in orders)
        {
            foreach (var item in order.Items)
            {
                tmp.Add(item.Name);
            }
        }
        // var oldTmp = new List<string>();
        // oldTmp.Add("legacy");
    }
}
