package hokit.assignment;

import java.sql.Connection;
import java.sql.DriverManager;

public class SQLite {
    public static Connection SQLite(){
        Connection conn = null;
        try {
            Class.forName("org.sqlite.JDBC");
            conn = DriverManager.getConnection("jdbc:sqlite:JavaAssignment.db");
        } catch ( Exception e ) {
            System.err.println( e.getClass().getName() + ": " + e.getMessage() );
            System.exit(0);
        }
        return conn;
    }
}
