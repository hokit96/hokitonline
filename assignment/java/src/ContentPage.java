import hokit.assignment.SQLite;

import javax.swing.*;
import java.awt.*;
import java.sql.*;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Vector;


//NOTE FOR MYSELF: Keep comment for most of the thing, just in case i FORGET and easy for people to understand!
public class ContentPage extends JFrame{
    //These line of code declared outside of a constructor to allow user access the members or components of the class.
    JFrame contentFrame;
    JTabbedPane tabPane;
    JPanel supplierEntry,itemEntry,registerAccount,purchaseRequisition,purchaseOrder,setting, displayRequisition;
    JTextField disUser;
    JComboBox chgRoles;
    static JTable displayRequis, disPurc;
    static JComboBox purcItemName,itemSupplier;
    static JTextField purcID;



    //This is a constructor
    public ContentPage() {

        //This is the login frame
        contentFrame = new JFrame();
        ImageIcon icon = new ImageIcon("icon.png");
        contentFrame.setSize(800, 600);
        contentFrame.setLocation(100,100);
        contentFrame.setIconImage(icon.getImage());

        //Tab section
        tabPane = new JTabbedPane();
        supplierEntry = new JPanel();
        itemEntry = new JPanel();
        registerAccount = new JPanel();
        purchaseRequisition = new JPanel();
        purchaseOrder = new JPanel();
        setting = new JPanel();
        displayRequisition = new JPanel();

        //This is to set dimension or size of the panel.
        supplierEntry.setPreferredSize(new Dimension(800, 600));
        itemEntry.setPreferredSize(new Dimension(800, 600));
        registerAccount.setPreferredSize(new Dimension(800, 600));
        purchaseRequisition.setPreferredSize(new Dimension(800, 600));
        purchaseOrder.setPreferredSize(new Dimension(800, 600));
        setting.setPreferredSize(new Dimension(800, 600));
        displayRequisition.setPreferredSize(new Dimension(800, 600));


        //This is to add tab on the tabpane
        tabPane.addTab("Supplier Entry", supplierEntry);
        tabPane.addTab("Item Entry", itemEntry);
        tabPane.addTab("Add Account", registerAccount);
        tabPane.addTab("Purchase Requisition", purchaseRequisition);
        tabPane.addTab("Display Purchase", displayRequisition);
        tabPane.addTab("Purchase Order", purchaseOrder);
        tabPane.addTab("Setting", setting);


        //This is to set color of the panel
        supplierEntry.setBackground(Color.white);
        supplierEntry.setBackground(Color.white);
        itemEntry.setBackground(Color.white);
        registerAccount.setBackground(Color.white);
        purchaseRequisition.setBackground(Color.white);
        purchaseOrder.setBackground(Color.white);
        setting.setBackground(Color.white);
        displayRequisition.setBackground(Color.white);

        //Supplier entry
        JLabel supplieridLbl = new JLabel("Supplier Tag:");
        JLabel suppliernameLbl = new JLabel("Supplier Name:");
        JLabel suppliertypeLbl = new JLabel("Supplier Type:");
        JTextField supplierID = new JTextField("", 20);
        JTextField supplierName = new JTextField("", 20);
        JComboBox supplierType = new JComboBox();
        supplierType.addItem("Groceries");
        supplierType.addItem("Food");
        supplierType.addItem("Stationary");
        JButton addSupplier = new JButton("Add");

        //Supplier entry component
        supplieridLbl.setBounds(75, 30, 100, 20);
        suppliernameLbl.setBounds(75, 60, 100, 20);
        suppliertypeLbl.setBounds(75, 90,100,20);
        supplierID.setBounds(250,30,150, 20);
        supplierName.setBounds(250 ,60,150, 20);
        supplierType.setBounds(250, 90, 150, 20);
        addSupplier.setBounds(320, 505, 120,30);

        supplierEntry.add(supplierID);
        supplierEntry.add(supplieridLbl);
        supplierEntry.add(suppliernameLbl);
        supplierEntry.add(supplierName);
        supplierEntry.add(suppliertypeLbl);
        supplierEntry.add(supplierType);
        supplierEntry.add(addSupplier);
        //__________________________________________________________________________________________________________//

        //Item entry
        JLabel itemidLbl = new JLabel("Item ID:");
        JLabel itemnameLbl = new JLabel("Item Name:");
        JLabel itemtypeLbl = new JLabel("Item Type:");
        JLabel itemsuppliedLbl = new JLabel("Supplied by:");
        JTextField itemID = new JTextField("", 20);
        JTextField itemName = new JTextField("", 20);
        itemSupplier = new JComboBox();
        JButton addItem = new JButton("Add");
        JComboBox itemType = new JComboBox();
        itemType.addItem("Groceries");
        itemType.addItem("Food");
        itemType.addItem("Stationary");

        //Item entry component
        itemidLbl.setBounds(75, 30, 100, 20);
        itemnameLbl.setBounds(75, 60, 100, 20);
        itemtypeLbl.setBounds(75, 90,100,20);
        itemsuppliedLbl.setBounds(75,120,100,20);
        itemID.setBounds(250,30,150, 20);
        itemName.setBounds(250 ,60,150, 20);
        itemType.setBounds(250, 90, 150, 20);
        itemSupplier.setBounds(250, 120,150,20);
        addItem.setBounds(320, 505, 120,30);

        itemEntry.add(itemidLbl);
        itemEntry.add(itemnameLbl);
        itemEntry.add(itemtypeLbl);
        itemEntry.add(itemsuppliedLbl);
        itemEntry.add(itemID);
        itemEntry.add(itemName);
        itemEntry.add(itemType);
        itemEntry.add(itemSupplier);
        itemEntry.add(addItem);
        //__________________________________________________________________________________________________________//

        //Add account
        JLabel usernameLbl = new JLabel("Username:");
        JLabel passwordLbl = new JLabel("Password:");
        JLabel userRolesLbl = new JLabel("Roles:");
        JTextField userUsername = new JTextField("", 20);
        JPasswordField userPassword = new JPasswordField("", 20);
        JButton addUser = new JButton("Add");
        JComboBox userRoles = new JComboBox();
        userRoles.addItem("admin");
        userRoles.addItem("manager");
        userRoles.addItem("staff");

        //Account component
        usernameLbl.setBounds(75, 30, 100, 20);
        passwordLbl.setBounds(75, 60, 100, 20);
        userRolesLbl.setBounds(75, 90,100,20 );
        userUsername.setBounds(250,30,150, 20);
        userPassword.setBounds(250 ,60,150, 20);
        userRoles.setBounds(250, 90, 150, 20);
        addUser.setBounds(320, 505, 120,30);

        registerAccount.add(usernameLbl);
        registerAccount.add(passwordLbl);
        registerAccount.add(userUsername);
        registerAccount.add(userPassword);
        registerAccount.add(userRolesLbl);
        registerAccount.add(userRoles);
        registerAccount.add(addUser);
        //__________________________________________________________________________________________________________//

        //Purchase requisitions
        JLabel purcIDLbl = new JLabel("Purchase ID");
        JLabel purcItemNameLbl = new JLabel("Item Name");
        JLabel purcQuantLbl = new JLabel("Quantity:");
        JLabel purcDateLbl = new JLabel("Date:");
        purcID = new JTextField();
        purcItemName = new JComboBox();
        JSpinner purcQuan = new JSpinner(new SpinnerNumberModel(0,0,100,1));
        Date myDate = new Date();
        JLabel purcDate = new JLabel(new SimpleDateFormat("dd-MM-yyyy").format(myDate).toString());
        JButton addRequisition = new JButton("Add");

        //Purchase requisition component
        purcIDLbl.setBounds(75,30,100,20);
        purcItemNameLbl.setBounds(75, 60, 100, 20);
        purcQuantLbl.setBounds(75, 90, 100, 20);
        purcDateLbl.setBounds(75, 120,100,20 );
        purcID.setBounds(250,30,150,20);
        purcItemName.setBounds(250,60,150, 20);
        purcQuan.setBounds(250 ,90,150, 20);
        purcDate.setBounds(250, 120, 300, 20);
        addRequisition.setBounds(320, 505, 120,30);

        purchaseRequisition.add(purcIDLbl);
        purchaseRequisition.add(purcID);
        purchaseRequisition.add(purcItemNameLbl);
        purchaseRequisition.add(purcQuantLbl);
        purchaseRequisition.add(purcDateLbl);
        purchaseRequisition.add(purcItemName);
        purchaseRequisition.add(purcQuan);
        purchaseRequisition.add(purcDate);
        purchaseRequisition.add(addRequisition);




        //__________________________________________________________________________________________________________//

        //displayRequisition
        displayRequis = new JTable();
        displayRequis.setEnabled(false);
        displayRequis.setBounds(0,0,800,600);
        displayRequisition.add(displayRequis);
        //For details for this, please scroll down for the function displayRequisi()


        //__________________________________________________________________________________________________________//

        //Purchase Order
        disPurc = new JTable();
        JLabel purchaseIDLbl= new JLabel("Purchase ID: ");
        JTextField purchaseID = new JTextField();
        JButton confirmOrder = new JButton("Confirm!");
        purchaseIDLbl.setBounds(10, 505, 120,30);
        purchaseID.setBounds(100, 512, 120,20);
        confirmOrder.setBounds(320, 505, 120,30);
        disPurc.setBounds(0,0,800,450);
        disPurc.setEnabled(false);
        purchaseOrder.add(purchaseIDLbl);
        purchaseOrder.add(purchaseID);
        purchaseOrder.add(confirmOrder);
        purchaseOrder.add(disPurc);


        //__________________________________________________________________________________________________________//


        //Setting
        JLabel userLbl = new JLabel("Username:");
        JLabel passLbl = new JLabel("Password:");
        JLabel rolesLbl = new JLabel("Roles:");
        disUser = new JTextField("", 20);
        JPasswordField chgPass = new JPasswordField("", 20);
        JButton chgUser = new JButton("Edit");
        chgRoles = new JComboBox();
        chgRoles.addItem("admin");
        chgRoles.addItem("manager");
        chgRoles.addItem("staff");

        //Setting component
        disUser.setEditable(false);
        userLbl.setBounds(75, 30, 100, 20);
        passLbl.setBounds(75, 60, 100, 20);
        rolesLbl.setBounds(75, 90,100,20 );
        disUser.setBounds(150,30,150, 20);
        chgPass.setBounds(150 ,60,150, 20);
        chgRoles.setBounds(150, 90, 150, 20);
        chgRoles.setEnabled(false);
        chgUser.setBounds(320, 505, 120,30);

        setting.add(userLbl);
        setting.add(passLbl);
        setting.add(rolesLbl);
        setting.add(disUser);
        setting.add(chgPass);
        setting.add(chgRoles);
        setting.add(chgUser);

        //ActionListener
        chgUser.addActionListener(e-> {
            if (chgPass.getText().equals("")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
                Connection conn = SQLite.SQLite();
                PreparedStatement prepState = null;

                try{
                    String sql = "update [user] set [password] = ?, [roles] = ? where [username] = ?;";
                    prepState = conn.prepareStatement(sql);
                    prepState.setString(1, chgPass.getText());
                    prepState.setString(2, chgRoles.getSelectedItem().toString());
                    prepState.setString(3, disUser.getText());
                    prepState.executeUpdate();
                    JOptionPane.showMessageDialog(null, "Successful update");
                    conn.close();
                }
                catch (SQLException a) {
                    JOptionPane.showMessageDialog(null, "Fail to update user!");
                }
            }});


        addUser.addActionListener(e-> {
            if (userUsername.getText().equals("") && userPassword.getText().equals("")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
            Connection conn = SQLite.SQLite();
            PreparedStatement prepState = null;

            try{
                String sql = "Insert into [user] (username, password, roles) values (?,?,?)";
                prepState = conn.prepareStatement(sql);
                prepState.setString(1, userUsername.getText());
                prepState.setString(2, userPassword.getText());
                prepState.setString(3, userRoles.getSelectedItem().toString());
                prepState.executeUpdate();
                JOptionPane.showMessageDialog(null, "Successful added a new user!");
                conn.close();

            }
            catch (SQLException a) {
                JOptionPane.showMessageDialog(null, "Failed to add a new user, user already existed!");
                System.out.println(a.toString());
            }
        }});

        addSupplier.addActionListener(e-> {
            if (supplierName.getText().equals("") && supplierID.getText().equals("")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
                Connection conn = SQLite.SQLite();
                PreparedStatement prepState = null;

                try{
                    String sql = "Insert into [supplier] (supplierid, suppliername, suppliertype) values (?,?,?)";
                    prepState = conn.prepareStatement(sql);
                    prepState.setString(1, supplierID.getText());
                    prepState.setString(2, supplierName.getText());
                    prepState.setString(3, supplierType.getSelectedItem().toString());
                    prepState.executeUpdate();
                    JOptionPane.showMessageDialog(null, "Successful added a new supplier!");
                    conn.close();
                    checkSupplierName();

                }
                catch (SQLException a) {
                    JOptionPane.showMessageDialog(null, "Failed to add a new supplier, supplier already existed!");
                }
            }});

        addItem.addActionListener(e-> {
            if (itemName.getText().equals("") && itemID.getText().equals("")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
                Connection conn = SQLite.SQLite();
                PreparedStatement prepState = null;

                try{
                    String sql = "Insert into [item] (itemid, itemname, itemtype, itemsupplier) values (?,?,?,?)";
                    prepState = conn.prepareStatement(sql);
                    prepState.setString(1, itemID.getText());
                    prepState.setString(2, itemName.getText());
                    prepState.setString(3, itemType.getSelectedItem().toString());
                    prepState.setString(4, itemSupplier.getSelectedItem().toString());
                    prepState.executeUpdate();
                    JOptionPane.showMessageDialog(null, "Successful added a new item!");
                    checkItemName();
                    conn.close();

                }
                catch (SQLException a) {
                    JOptionPane.showMessageDialog(null, "Failed to add a new item, item already existed!");
                }
            }});

        addRequisition.addActionListener(e-> {
            if (purcQuan.equals("0")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
                Connection conn = SQLite.SQLite();
                PreparedStatement prepState = null;

                try{
                    String sql = "Insert into [purchase] (purchaseID, itemcode, quantity, date, status) values (?,?,?" +
                            ",?, 'pending')";
                    prepState = conn.prepareStatement(sql);
                    prepState.setString(1, purcID.getText());
                    prepState.setString(2, purcItemName.getSelectedItem().toString());
                    prepState.setString(3, purcQuan.getValue().toString());
                    prepState.setString(4, purcDate.getText());
                    prepState.executeUpdate();
                    JOptionPane.showMessageDialog(null, "Successful added a new purchase requisition!");
                    conn.close();
                }
                catch (SQLException a) {
                    JOptionPane.showMessageDialog(null, "Failed to add a new purchase requisition, purchase " +
                            "requisition ID already existed!");
                }
            }
            displayRequisi();
            disPurcs();
            autoGenPurcID();
        });

        confirmOrder.addActionListener(e-> {
            if (purchaseID.getText().equals("")){
                JOptionPane.showMessageDialog(null, "Please insert at least something!");
            }
            else{
                Connection conn = SQLite.SQLite();
                PreparedStatement prepState = null;

                try{
                    String sql = "update purchase set status='confirmed' where purchaseid=?";
                    prepState = conn.prepareStatement(sql);
                    prepState.setString(1, purchaseID.getText());

                    prepState.executeUpdate();
                    JOptionPane.showMessageDialog(null, "Successful confirmed order!");
                    conn.close();
                    displayRequisi();
                    disPurcs();
                }
                catch (SQLException a) {
                    JOptionPane.showMessageDialog(null, "Failed to confirm, please try again later.");
                }
            }});



        //SetLayout to null
        supplierEntry.setLayout(null);
        itemEntry.setLayout(null);
        registerAccount.setLayout(null);
        purchaseRequisition.setLayout(null);
        purchaseOrder.setLayout(null);
        setting.setLayout(null);
        displayRequisition.setLayout(null);

        contentFrame.add(tabPane);
        contentFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        contentFrame.setResizable(false);
        contentFrame.setLocationRelativeTo(null);
        contentFrame.setVisible(true);
    }



    //By default, all feature (or tab) are enabled.
    //This method is to remove register account if the user login into the system is manager and staff
    public void adminFeatureEnabled(boolean a) {
        if (!a) {
            tabPane.removeTabAt(tabPane.indexOfComponent(registerAccount));
        }
    }
    //This method is to remove register account and purchase order if the user who log into the system is staff
    public void managerFeatureEnabled(boolean a) {
        if(!a) {
            tabPane.removeTabAt(tabPane.indexOfComponent(purchaseOrder));
        }
    }

    public static void displayRequisi(){
        try {
            Connection conn = SQLite.SQLite();
            Statement statement = conn.createStatement();
            String sql = "select * from purchase";
            ResultSet resultSet = statement.executeQuery(sql);
            displayRequis.setModel(DbUtils.resultSetToTableModel(resultSet));
            conn.close();
        } catch (SQLException sq) {
            JOptionPane.showMessageDialog(null, sq);

        }
    }
    public static void disPurcs(){
        try {
            Connection conn = SQLite.SQLite();
            Statement statement = conn.createStatement();
            String sql = "select * from purchase";
            ResultSet resultSet = statement.executeQuery(sql);
            disPurc.setModel(DbUtils.resultSetToTableModel(resultSet));
            conn.close();
        } catch (SQLException sq) {
            JOptionPane.showMessageDialog(null, sq);

        }
    }
    public static void checkItemName(){
        Connection conn = SQLite.SQLite();
        String sql = "select itemname from item";
        try{
            Statement statement = conn.createStatement();
            ResultSet resultSet = statement.executeQuery(sql);
            Vector vec = new Vector();
            while (resultSet.next()) {
                String list = resultSet.getString("itemname");
                vec.add(list);
            }
            conn.close();
            purcItemName.setModel(new DefaultComboBoxModel(vec));
        } catch (SQLException lol){
            System.out.println(lol.toString());
        }

    }

    public static void checkSupplierName(){
        Connection conn = SQLite.SQLite();
        String sql = "select suppliername from supplier";
        try{
            Statement statement = conn.createStatement();
            ResultSet resultSet = statement.executeQuery(sql);
            Vector vec = new Vector();
            while (resultSet.next()) {
                String list = resultSet.getString("suppliername");
                vec.add(list);
            }
            conn.close();
            itemSupplier.setModel(new DefaultComboBoxModel(vec));
        } catch (SQLException lol){
            System.out.println(lol.toString());
        }

    }

    public static void autoGenPurcID() {
        Connection conn = SQLite.SQLite();
        ResultSet resSet = null;

        try {
            Statement statement = conn.createStatement();
            statement.execute("select MAX(purchaseid)+1 from [purchase]");
            resSet = statement.getResultSet();
            if (resSet.next()) {
                purcID.setText(resSet.getString(1));
            }
            conn.close();

        }
        catch (SQLException e){
            System.out.println(e.toString());
        }
    }

}
