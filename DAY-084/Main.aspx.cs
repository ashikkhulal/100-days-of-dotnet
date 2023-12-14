using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokensQueue"] == null)
            {
                Queue<int> tokensQueue = new Queue<int>();
                Session["TokensQueue"] = tokensQueue;
            }
        }

        protected void BtnGetToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokens = (Queue<int>)Session["TokensQueue"];
            LblQueueStatus.Text = "There are " + tokens.Count.ToString() + " customers before you in the queue.";

            if (Session["LastIssuedToken"] == null)
            {
                Session["LastIssuedToken"] = 0;
            }

            int nextToken = (int)Session["LastIssuedToken"] + 1;
            Session["LastIssuedToken"] = nextToken;
            tokens.Enqueue(nextToken);

            AddTokensToListBox(tokens);

        }

        private void AddTokensToListBox(Queue<int> tokens)
        {
            LstToken.Items.Clear();
            foreach (int token in tokens)
            {
                LstToken.Items.Add(token.ToString());
            }
        }

        private void NextCustomer(TextBox textBox, int counterNumber)
        {
            Queue<int> tokensQueue = (Queue<int>)Session["TokensQueue"];
            if (tokensQueue.Count <= 0)
            {
                textBox.Text = "No customers in queue!";
                textBox.Style["text-align"] = "center";
            }
            else
            {
                int tokenServed = tokensQueue.Dequeue();
                textBox.Text = tokenServed.ToString();
                TxtDisplay.Text = $"Now serving token number: " + tokenServed.ToString() + ", please proceed to Counter " + counterNumber.ToString();
                TxtDisplay.Style["text-align"] = "center";
                textBox.Style["text-align"] = "center";
                AddTokensToListBox(tokensQueue);
            }
        }

        protected void BtnCounter1_Click(object sender, EventArgs e)
        {
            
            NextCustomer(TxtCounter1, 1);
        }

        protected void BtnCounter2_Click(object sender, EventArgs e)
        {
            NextCustomer(TxtCounter2, 2);
        }

        protected void BtnCounter3_Click(object sender, EventArgs e)
        {
            NextCustomer(TxtCounter3, 3);
        }
    }
}