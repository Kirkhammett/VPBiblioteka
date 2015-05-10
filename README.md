# VPBiblioteka
Standard Windows forms library project.
Преамбула:
============
<p>Целта на следнава windows forms апликација е да се имплементира база со книги, подржана од MySQL систем за бази. Начинот за работа е многу едноставен.</p>
* * *

<ul>
<li> Главниот прозорец: <br />
<p>Пример, главниот прозорец се состои од 3 сегменти:<br>
- Азбучно подредена листа од книги, земени од базата од соодветна келија (Прикажана со <span style="color:red;">црвено</span>).<br>
- Неколку не-едитирачки тескт полиња кои ги содржат информациите за книгите (Означени со <span style="color:blue;">плаво</span>).<br>
- Листа од радио-копчиња кои служат за филтрирање на листата од книги (Означени со <span style="color:green;">зелено</span>)<br>
</p>
<img src="http://img.prntscr.com/img?url=http://i.imgur.com/p8LgNMz.png" alt="Glaven" /> </li>
<br>
<li> Прозорец за додавање книги: <br />
<p>Книгите се додаваат така што мора да се внесат сите информации точно според барањата на валидација и точно сите полиња да се пополнети. Drop-down листата автоматски генерира можни жанрови.</p><br>
<img src="http://img.prntscr.com/img?url=http://i.imgur.com/Utg7yX6.png" alt="Dodaj" /> </li>
</li>
<br>
<li> Прозорец за нарачки: <br />
<p>Нарачките се остваруваат ако и само ако е селектирана книга од листата. Притоа, копчето за нарачка станува функционално. Прозорецот за нарачки бара основни информации за контакт, подржани со валидација и регуларни изрази. Откако се валидира и се нарача, информацијата се внесува во базата. Сите нарачки можат да се проследат на следнава  <a href="http://oriondev.me/Customers/Customers.php" target="_blank">страна.</a>  За приказ користена PHP скрипта која се поврзува до соодветната табела во базата</p>
<br>
<img src="http://img.prntscr.com/img?url=http://i.imgur.com/OoliRUf.png" alt="Naracaj" /> </li>
</li>
<br>
</ul> 
Опис на функции
=====
Пример настан при селектирање на книга:
```c#
private void selectSpecific_books(String book)
{
    clearBooks();
    string Select = "SELECT * FROM Books WHERE `Book_name` =" + '"' + book + '"' + ";";
    //Debugging the command
    //MessageBox.Show(Select, "Unable to connect to database!");
    MySqlDataReader Reader;
    MySqlConnection con = new MySqlConnection(Connection);
    try
    {
        con.Open();
        MySqlCommand cmd = new MySqlCommand(Select, con);
        Reader = cmd.ExecuteReader();
        while (Reader.Read())
        {
            tbName.Text = (Reader.GetString("Auth_name"));
            tbSurname.Text = (Reader.GetString("Auth_surname"));
            tbPubHouse.Text = (Reader.GetString("Publish_house"));
            tbPubYear.Text = (Reader.GetString("Publish_year"));
            rtbSummary.Text = (Reader.GetString("Book_description"));
        }
    }
    catch (MySqlException ex)
    {
        MessageBox.Show(ex.Message, "Unable to connect to database!");
    }
    finally
    {
        con.Close();
    }
}
```
Примери за валидација:
```c#
 private void tbGodIzdavanje_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //Backspace, smee da se brise
    {
        e.Handled = false;
    }
    else
    {
        e.Handled = true;
        MessageBox.Show("Внесете валидни години, само бројки.", "Несоодветен влез!");
    }
    if (tbGodIzdavanje.Text.Trim().Length > 3)
    {
        MessageBox.Show("Внесете валидна големина на години, 4 бројки.", "Несоодветен влез!");
        tbGodIzdavanje.Text = "";
        e.Handled = true;
    }
}
```
Изработиле
=====
<p><b><a href="http://courses.finki.ukim.mk/user/view.php?id=3930" target="_blank">Филип Боев - 133086</a></b></p>
<p><b><a href="http://courses.finki.ukim.mk/user/view.php?id=4052" target="_blank">Кристина Танева - 133021</a></b></p>
</p>
