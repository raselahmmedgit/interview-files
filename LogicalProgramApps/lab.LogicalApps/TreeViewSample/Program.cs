using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeViewSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree View");

            var treeViewList = new List<Node>();

            var entityModelList = new List<EntityModel>() {
                new EntityModel() { Id = 1, Name = "Entity 1", ParentId = 0 },
                new EntityModel() { Id = 2, Name = "Entity 2", ParentId = 0 },
                new EntityModel() { Id = 3, Name = "Entity 3", ParentId = 0 },
                new EntityModel() { Id = 4, Name = "Entity 1.1", ParentId = 1 },
                new EntityModel() { Id = 5, Name = "Entity 1.2", ParentId = 1 },
                new EntityModel() { Id = 6, Name = "Entity 2.1", ParentId = 2 },
                new EntityModel() { Id = 7, Name = "Entity 3.1", ParentId = 3 },
                new EntityModel() { Id = 8, Name = "Entity 3.2", ParentId = 3 },
                new EntityModel() { Id = 9, Name = "Entity 2.1.1", ParentId = 6 },
                new EntityModel() { Id = 10, Name = "Entity 3.2.1", ParentId = 8 },
            };

            foreach (var entityModel in entityModelList)
            {
                var parentNode = new Node();
                var childEntityModelList = new List<EntityModel>();
                if (entityModel.ParentId == 0)
                {
                    //Console.WriteLine("--" + entityModel.Name);
                    parentNode = new Node() { Id = entityModel.Id, Name = entityModel.Name, ParentId = entityModel.ParentId };
                    childEntityModelList = entityModelList.Where(x => x.ParentId == entityModel.Id).ToList();
                }
                else
                {
                    childEntityModelList = entityModelList.Where(x => x.ParentId == entityModel.Id).ToList();
                }

                foreach (var childEntityModel in childEntityModelList)
                {
                    //Console.WriteLine("------" + childEntityModel.Name);
                    var childNode = new Node() { Id = childEntityModel.Id, Name = childEntityModel.Name, ParentId = childEntityModel.ParentId };
                    parentNode.Child = childNode;
                }

                treeViewList.Add(parentNode);
            }

            foreach (var treeView in treeViewList)
            {
                Console.WriteLine(treeView.Name);
                if (treeView.Child != null) 
                {
                    Console.WriteLine(treeView.Child.Name);
                }
            }

            Console.ReadLine();
        }
    }

    class EntityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }

    class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public Node Child { get; set; }
    }
}
