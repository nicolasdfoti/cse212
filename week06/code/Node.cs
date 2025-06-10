using System.Security.Cryptography.X509Certificates;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }

        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true;
        }

        else
        {
            if (value > Data)
            {
                if (Right == null)
                {
                    return false;
                }

                else
                {
                    if (Right.Contains(value))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            else
            {
                if (Left == null)
                {
                    return false;
                }

                else
                {
                    if (Left.Contains(value))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // return 0; Replace this line with the correct return statement(s)

        if (Right == null && Left == null)
        {
            return 1;
        }

        else
        {
            int rightHeight = 0;
            int leftHeight = 0;

            if (Left != null)
            {
                leftHeight = Left.GetHeight() + 1;
            }

            if (Right != null)
            {
                rightHeight = Right.GetHeight() + 1;
            }

            return Math.Max(rightHeight, leftHeight);
        }
    }
}