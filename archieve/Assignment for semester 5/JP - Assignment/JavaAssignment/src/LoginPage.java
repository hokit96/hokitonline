import hokit.assignment.SQLite;

import javax.swing.*;
import java.sql.*;
import java.awt.*;

//NOTE FOR MYSELF: Keep comment for most of the thing, just in case i FORGET and easy for people to understand!
public class LoginPage extends JFrame{
    JFrame loginFrame;
    JTextField userTxt;
    JPasswordField passTxt;

    void LoginPage() {
        //This is the login frame
        ImageIcon icon = new ImageIcon("icon.png");
        loginFrame = new JFrame("Login!");
        loginFrame.setSize(300, 300);
        loginFrame.setLocation(100,100);
        loginFrame.setIconImage(icon.getImage());

        //This is the item inside login frame
        JPanel panel = new JPanel();
        JButton loginBtn = new JButton("Login");
        JButton resetBtn = new JButton("Reset");
        userTxt = new JTextField("", 20);
        passTxt = new JPasswordField("", 20);
        JLabel logo = new JLabel(new ImageIcon("logo.png"));
        JLabel userLbl = new JLabel("Username:");
        JLabel passLbl = new JLabel("Password:");

        panel.setBackground(Color.white);

        //This is for set location
        logo.setBounds(0,0,300,100);
        userLbl.setBounds(40, 100, 100,10);
        passLbl.setBounds(40, 130, 100,10);
        userTxt.setBounds(110, 100,100,20);
        passTxt.setBounds(110,130,100,20);
        loginBtn.setBounds(40,180,80,20);
        resetBtn.setBounds(130, 180, 80, 20);

        //This is to add item on frame and on panel
        panel.add(userLbl);
        panel.add(userTxt);
        panel.add(passLbl);
        panel.add(passTxt);
        panel.add(loginBtn);
        panel.add(resetBtn);
        panel.add(logo);
        panel.setLayout(null);
        loginFrame.add(panel);

        //This is to add action listener on button
        loginBtn.addActionListener(e -> checkLogin());

        //This action listener is to reset the text inside textfield.
        resetBtn.addActionListener(e -> {
            userTxt.setText("");
            passTxt.setText("");
        });

        //This line of code allow user to press enter (without pressing on login button)
        passTxt.addActionListener(e -> checkLogin());

        //This code is to make the frame visible
        loginFrame.setLocationRelativeTo(null);
        loginFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        panel.setLayout(null);
        loginFrame.setVisible(true);
    }

    //Login frame will be called everytime user launch the program.
    public static void main(String args[]){
        (new LoginPage()).LoginPage();
    }

    //Check login method here
    public void checkLogin(){
        Connection conn = SQLite.SQLite();
        ResultSet resSet = null;
        PreparedStatement prepState = null;

        try {
            String sql = "select * from user where [username] = ? and password = ?";
            prepState = conn.prepareStatement(sql);
            prepState.setString(1, userTxt.getText());
            prepState.setString(2, passTxt.getText());
            resSet = prepState.executeQuery();
            if (resSet.next()){
                loginFrame.dispose();
                ContentPage contentPage = new ContentPage();
                String role = resSet.getString("roles");
                boolean adminEnabled = true;
                boolean managerEnabled = true;
                ContentPage.displayRequisi();
                ContentPage.disPurcs();
                ContentPage.checkItemName();
                ContentPage.checkSupplierName();
                ContentPage.autoGenPurcID();
                contentPage.disUser.setText(userTxt.getText());

                //This line of code is to change the component of the frame to respective user.
                if (role.equals("admin")){
                    contentPage.contentFrame.setTitle("Menu - Admin!");
                    contentPage.disUser.setEditable(true);
                    contentPage.chgRoles.setEnabled(true);
                } else if(role.equals("manager")){
                    contentPage.contentFrame.setTitle("Menu - Manager!");
                    contentPage.chgRoles.setSelectedItem("manager");
                    adminEnabled = false;
                }else if (role.equals("staff")){
                    contentPage.contentFrame.setTitle("Menu - Staff!");
                    contentPage.chgRoles.setSelectedItem("staff");
                    adminEnabled = false;
                    managerEnabled = false;
                }
                //These line of code is to call method that declared in ContentPage.java
                contentPage.adminFeatureEnabled(adminEnabled);
                contentPage.managerFeatureEnabled(managerEnabled);
                conn.close();
            }
            else {
                JOptionPane.showMessageDialog(null, "Incorrect username or password");
                passTxt.setText("");
            }

        } catch (SQLException a) {

            System.out.println(a.toString());
        }
    }

}