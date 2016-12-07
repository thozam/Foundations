using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        int icount = 0;
        bool continueProgram = true;
        ItemData[] itemprop = new ItemData[10];

        do      
        {       
            Console.WriteLine("Please chose an option below"); 
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item (by giving its item number)");
            Console.WriteLine("3. Delete an item (by giving its item number)");
            Console.WriteLine("4. List all items in the database");
            Console.WriteLine("5. Quit");
            
            string strx = Console.ReadLine();   

            int optx = int.Parse(strx); 

            Console.WriteLine();

            switch (optx)
            {
                case 1:	
                    {
                        if (icount == 100)
                        {
                            Console.WriteLine("Sorry, you have reached the limit of 100 items");
                            break;
                        }
                        if (icount == itemprop.Length)
                        {
                            ItemData[] tempArray = new ItemData[icount + 10];
                            for (int i = 0; i < icount; i++)
                            {
                                tempArray[i] = itemprop[i];
                            }
                            itemprop = tempArray;
                        }
                        Console.WriteLine("ADDING AN ITEM");
                        Console.WriteLine("Item number: ");
                        string case1Input = Console.ReadLine();
                        itemprop[icount].itemIDNo = int.Parse(case1Input);
                        Console.WriteLine("Description");
                        itemprop[icount].sDescription = Console.ReadLine();
                        Console.WriteLine("Price per item: ");
                        case1Input = Console.ReadLine();
                        itemprop[icount].dblPricePerItem = double.Parse(case1Input);
                        Console.WriteLine("Quantity on hand: ");
                        case1Input = Console.ReadLine();
                        itemprop[icount].iQuantityOnHand = int.Parse(case1Input);
                        Console.WriteLine("Our cost per item: ");
                        case1Input = Console.ReadLine();
                        itemprop[icount].dblOurCostPerItem = double.Parse(case1Input);
                        itemprop[icount].dblValueOfItem = itemprop[icount].dblPricePerItem * itemprop[icount].iQuantityOnHand;
                        icount++;
                        break;
                    }

                case 2: 
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                
                                Console.WriteLine("Please enter new quantity of {0}", itemprop[x].sDescription);
                                string case2Input = Console.ReadLine();
                                itemprop[x].iQuantityOnHand = int.Parse(case2Input);
                                itemprop[x].dblValueOfItem = itemprop[x].dblPricePerItem * itemprop[x].iQuantityOnHand;
                                // For simplicity, user can only change quantity. A switch statement could easily give more options
                                // Please let me know if you want me to add that
                            }
                        }

                        if (!fFound) 
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case 3: 
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                for (int i = x; i < icount; i++)
                                {
                                    itemprop[i] = itemprop[i + 1];
                                }
                            }
                        }

                        if (fDeleted)
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        icount--;

                        break;
                    }

                case 4:	 
                    {
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                        
                        for (int i = 0; i < icount; i++)
                        {
                            Console.Write("{0,5}  ", i+1);
                            Console.Write("{0,6}  ", itemprop[i].itemIDNo);
                            Console.Write("{0,-20}  ", itemprop[i].sDescription);
                            Console.Write("{0,5}  ", itemprop[i].dblPricePerItem);
                            Console.Write("{0,3}  ", itemprop[i].iQuantityOnHand);
                            Console.Write("{0,4}  ", itemprop[i].dblOurCostPerItem);
                            Console.Write("{0,5}  ", itemprop[i].dblValueOfItem);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    }


                case 5:
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if ( strresp == "y" || strresp == "Y" )
                        {
                            continueProgram = false;
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Option, try again");

                        break;
                    }
            }
        }
        while (continueProgram);
    }
}