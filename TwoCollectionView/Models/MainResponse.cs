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

    }
    public ParentEntryDetails(string test)
    {
        Test = test;
    }
    public List<EntryDetails> ParentList { get; set; }
    public List<EntryDetails> ParentList2 { get; set; }

    //[ICommand]
    //public async Task LoadMoreData()
    //{
    //    //if (IsLoading) return;

    //    //if (_allAnimals?.Count > 0)
    //    //{
    //    //    IsLoading = true;
    //    //    await Task.Delay(2000);
    //    //    //AnimalList.AddRange(_allAnimals.Skip(AnimalList.Count).Take(_pageSize).ToList());
    //    //    //AnimalList2[1].AddRange(_allAnimals.Skip(AnimalList2[1].Count)
    //    //    //    .Take(_pageSize).ToList());

    //    //    ParentTestList[0].ParentList2.AddRange(_allAnimals
    //    //        .Skip(ParentTestList[0].ParentList2.Count)
    //    //        .Take(_pageSize).ToList());

    //    //    IsLoading = false;
    //    //}
    //}
    //public ObservableRangeCollection<ObservableRangeCollection<EntryDetails>> ParentList2 { get; set; }

}
