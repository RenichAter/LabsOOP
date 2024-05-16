using Ex3;
NodeOfTree<double> first = new NodeOfTree<double>(1);
NodeOfTree<double> sekonda = new NodeOfTree<double>(21);
NodeOfTree<double> sekondb = new NodeOfTree<double>(22);
NodeOfTree<double> thirtb = new NodeOfTree<double>(322);
first.AddChild(sekonda);
first.AddChild(sekondb);
sekondb.AddChild(thirtb);
first.PrintValues();