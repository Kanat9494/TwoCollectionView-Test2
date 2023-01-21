namespace TwoCollectionView.Models;

public class MainResponse
{
    public int Count { get; set; }
    public List<EntryDetails> Entries { get; set; }
}

public class EntryDetails
{
    public string API { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}

public class EntryDetails2
{
    public string API { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}

public class ParentEntryDetails
{
    public string Test { get; set; }

    public ParentEntryDetails()
    {
        Test = "This it the test text";
    }
    
    public List<EntryDetails> ParentList { get; set; }
    public List<EntryDetails> ParentList2 { get; set; }

    
}
