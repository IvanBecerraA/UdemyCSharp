

using _31_SQL_Conexion;

try
{

    DB db = new DB("localhost", "CSharpDB", "sa", "sasa");
    db.Connect();
    db.Close();

}
catch
{
    db.Close();
}