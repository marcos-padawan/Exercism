using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}
public class Tree
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public List<Tree> Children { get; set; }
    public bool IsLeaf => Children.Count == 0;
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
       
        records = records.OrderBy(q => q.RecordId).ToList();            //  

        var trees = new List<Tree>();
        var previousRecordId = 0; //mudou para 0

        if (!records.Any())                                                //
        {
            throw new ArgumentException();
        }

        foreach (var record in records)
        {
            var t = new Tree { Children = new List<Tree>(), Id = record.RecordId, ParentId = record.ParentId };

            if ((t.Id == 0 && t.ParentId != 0) ||
                (t.Id != 0 && (t.ParentId >= t.Id || t.Id != previousRecordId)))      // mudou o if      
            {
                throw new ArgumentException();
            }
            trees.Add(t);
            ++previousRecordId;
        }

        foreach (var item in trees.Skip(1))                                 //
        {
            trees.First(x => x.Id == item.ParentId).Children.Add(item);     //
        }
        
        return trees.First(t => t.Id == 0);                                 //
    }
}