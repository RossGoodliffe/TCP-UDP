import java.net.*;
import java.io.*;

public class UDPClient
{
    public static void main (String[] args)
    {
        try
        {
            DatagramSocket socket = new DatagramSocket ();
            byte[] buf = new byte[256];
            String messg = "Hello UDP Server\n";
            buf = messg.getBytes ();
            InetAddress address = InetAddress.getByName ("127.0.0.1");
            DatagramPacket packet = new DatagramPacket (buf, buf.length, address, 4567);

			      socket.send(packet);
        }
        catch (IOException e)
        {

        }
    }
}
