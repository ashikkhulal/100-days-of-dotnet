# DAY-064:

## Where are indexers used in .NET framework:
To store or retrieve data from session state or application state variables, we use indexers.

```
// Using the string indexer to store session data
Session["Session1"] = "Session 1 Data";
// Using the string indexer to store session data
Session["Session2"] = "Session 2 Data";

// Using the integral indexer to retrieve data 
Response.Write("Session 1 Data = " + Session[0].ToString());
// Using the string indexer to retrieve data 
Response.Write("Session 2 Data = " + Session["Session2"].ToString());
```

Another example of indexers usage in .NET is to retrieve data from a specific column when looping thru "SqlDataReader" object. We can use either integral indexer or string indexers.
```
string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
using (SqlConnection con = new SqlConnection(CS))
{
    SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
    con.Open();
    SqlDataReader rdr = cmd.ExecuteReader();
    while (rdr.Read())
    {
        // Using integral indexer to retrieve Id column value
        Response.Write("Id = " + rdr[0].ToString() + " ");
        // Using string indexer to retrieve Id column value
        Response.Write("Name = " + rdr["Name"].ToString());
    }
}
```


## What are indexers:

Indexers allow instances of a class to be indexed just like arrays.