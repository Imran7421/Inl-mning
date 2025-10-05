namespace Inlämning
{
    public class TradeRequest
    {
        public string RequestingUser { get; set; }
        public string UserItem { get; set; }
        public string TargetItem { get; set; }
        public string Status { get; set; }
        public string ItemOwner { get; set; }

        // Constructor for TradeRequest
        public TradeRequest(string requestingUser, string userItem, string targetItem, string itemOwner)
        {
            RequestingUser = requestingUser;
            UserItem = userItem;
            TargetItem = targetItem;
            ItemOwner = itemOwner;
            Status = "Pending";  // Default status, you can change it as per your logic
        }

        // Getter methods
    public string GetRequestingUserEmail() => RequestingUser;
    public string GetUserItem() => UserItem;
    public string GetTargetItem() => TargetItem;
    public string GetStatus() => Status;
    public string GetItemOwner() => ItemOwner;
    }
}