using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
  public class Database
  {
    private string connetionString = @"Data Source=LAPTOP-J4VFA095;Initial Catalog=QLSV;Integrated Security=True";
    private SqlConnection conn;
    private DataTable dataT;
    private SqlCommand sqlC;
    
    public Database()
    {
      try{
        conn = new SqlConnection(connetionString);
      }catch (Exception ex){
        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
      }
    }

    public DataTable SelectData(string sql, List<CustomParameter> list)
    {
      try{
        conn.Open();
        sqlC = new SqlCommand(sql, conn); //truyền vào câu lệnh truy vấn
        sqlC.CommandType = CommandType.StoredProcedure; //set command type cho SqlCommand
        
        foreach (var pa in list) //gán các tham số cho SqlCommand
        {
          sqlC.Parameters.AddWithValue(pa.name, pa.value);
        }
        dataT = new DataTable();
        dataT.Load(sqlC.ExecuteReader());
        //int admin = int.Parse(dataT.Rows[2].ToString());
        return dataT;
      }catch (Exception ex){
        MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
        return null;
      }finally{
        conn.Close();
      }
    }


    public DataRow Select(string sql)
    {
      try{
        conn.Open();//mở kết nối
        sqlC = new SqlCommand(sql, conn);
        dataT = new DataTable();
        dataT.Load(sqlC.ExecuteReader());//thực thi câu lệnh
        return dataT.Rows[0];//trả về kết quả
      }catch (Exception ex){
        MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
        return null;
      }finally{
        conn.Close();
      }
    }


    public DataTable SelectDS(string sql)
    {
      try
      {
        conn.Open();
        sqlC = new SqlCommand(sql, conn);
        dataT = new DataTable();
        dataT.Load(sqlC.ExecuteReader());
        return dataT;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
        return null;
      }
      finally
      {
        conn.Close();
      }
    }


    public int ExeCute(string sql, List<CustomParameter> lstPara)
    {
      try {
        conn.Open();//mở kết nối
        sqlC = new SqlCommand(sql, conn);//thực thi câu lệnh sql
        sqlC.CommandType = CommandType.StoredProcedure;
        
        foreach (var p in lstPara){
          sqlC.Parameters.AddWithValue(p.name, p.value);
        }
        var rs = sqlC.ExecuteNonQuery();//lấy kết quả thực thi truy vấn
        return (int)rs;//trả về kết quả
      }catch (Exception ex){
        MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
        return -100;
      }finally{
        conn.Close();//cuối cùng đóng kết nối
      }
    }



  }
}
