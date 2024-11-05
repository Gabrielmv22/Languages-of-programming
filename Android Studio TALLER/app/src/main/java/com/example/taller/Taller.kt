package com.example.taller

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import java.io.BufferedReader
import java.io.FileInputStream
import java.io.InputStreamReader
import java.sql.SQLOutput

public class Taller extends AppCompaActivity {
    private EditText txtCliente
    private EditText txtListado


}
class Taller : AppCompatActivity() {



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_taller)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
    }

    this.txtListado=findViewById(R.id.txtListado);
    this.txtCliente=findViewById(R.id.txtCliente);

}

public class Taller extends AppCompatActivity {
    public void Guardar(View vista)
    String texto=txtCliente.getText().toString()."\n";
    FileInputStream file=null;
    try{
        file=openFIleOutput("text.txt",MODE_APPEND);
        file.wirte(texto.getBytes());
    } catch (Exception e)
    {
        e.printStackTrace();
    }finally {
        if(file!null){
            try{
                file.close();
            } catch (Exception ex){
                ex.printStackTrace();
            }
        }
    }
}

public class Taller extends AppCompatActivity {
    public void Leer(View vista){
        FileInputStream file=null;
        try {
            file=openFileInput("texto.txt");
            InputStreamReader Leerfile=new InputStreamReader(file);
            BufferedReader buferLeer=new BufferedReader(Leerfile);
            String linea;
            StringBuilder parrafo=new StringBuilder();
            while ((linea=buferleer.readLine())!null){
                parrafo.append(linea).append("\n");

            }
            txtListado.setText(parrafo);

        }catch (Exception e){
            System.out.println(e.getMessage());
        } finally {
            if (file!=null){
                try{
                    file.close();
                } catch (Exception e){
                    System.out.println(e.getMessage());
                }
            }
        }
    }
}