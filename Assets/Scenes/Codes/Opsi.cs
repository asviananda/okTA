using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*

INFO SCENE :

0 : homepage
1 : hutan awal
2 : salju awal
3 : hutan awal terbakar
4 : hutan kering
5 : hutan terbakar
6 : salju cair
7 : ambil sampah
8 : nebang pohon
9 : buang sampah
10 : kota awal
11 : kota polusi
12 : hutan akhir

*/

public class Opsi : MonoBehaviour
{
 
    public void Back_HutanAwal() //tombol 'Back' pada scene hutan awal
    {
        SceneManager.LoadScene(0);
    }

    public void Okay_HutanAwal() //tombol 'Check' pada scene hutan awal
    {
        SceneManager.LoadScene(8);
    }

    public void Back_NebangPohon() //tombol 'Back' pada scene nebang pohon
    {
        SceneManager.LoadScene(1);
    }

    public void Okay_NebangPohon() //tombol 'Check' pada scene nebang pohon
    {
        SceneManager.LoadScene(4);
    }

    public void Okay_HutanKering() //tombol 'Check' pada scene hutan kering
    {
        SceneManager.LoadScene(9);
    }

    public void Back_BuangSampah() //tombol 'Back' pada scene buang sampah
    {
        SceneManager.LoadScene(4);
    }

    public void Okay_BuangSampah() //tombol 'Check' pada scene buang sampah
    {
        SceneManager.LoadScene(3);
    }

    public void Back_HutanTerbakar() //tombol 'Back' pada scene hutan terbakar
    {
        SceneManager.LoadScene(9);
    }

    public void Back_KotaPolusi() //tombol 'Back' pada scene kota polusi
    {
        SceneManager.LoadScene(5);
    }

    public void Okay_Penanggulangan() //tombol 'Check' pada scene kutub cair & kota polusi
    {
        SceneManager.LoadScene(7);
    }

    public void Back_KutubCair() //tombol 'Back' pada scene kutub cair
    {
        SceneManager.LoadScene(5);
    }

     public void Kutub_Back_AmbilSampah() //tombol 'Kutub' pada tombol back scene ambil sampah 
    {
        SceneManager.LoadScene(6);
    }

     public void Kota_Back_AmbilSampah() //tombol 'Kota' pada tombol back scene ambil sampah
    {
        SceneManager.LoadScene(11);
    }

     public void Okay_AmbilSampah() //tombol 'Check' pada scene ambil sampah
    {
        SceneManager.LoadScene(12);
    }

    public void Replay_AmbilSampah() //tombol 'Replay' pada scene ambil sampah
    {
        SceneManager.LoadScene(7);
    }
    
    public void Okay_NanemPohon() //tombol 'Check' pada scene nanem pohon
    {
        SceneManager.LoadScene(12);
    }

    public void Back_Ke_HutanAkhir() //tombol 'Back' pada scene kota awal&kutub awal
    {
        SceneManager.LoadScene(12);
    }

    public void Kutub_HutanTerbakar() //tombol 'Kutub' pada scene hutan terbakar
    {
        SceneManager.LoadScene(6);
    }

    public void Kota_HutanTerbakar() //tombol 'Kota' pada scene hutan terbakar
    {
        SceneManager.LoadScene(11);
    }

    public void Kutub_HutanAkhir() //tombol 'Kutub' pada scene hutan akhir
    {
        SceneManager.LoadScene(2);
    }

    public void Kota_HutanAkhir() //tombol 'Kota' pada scene hutan akhir
    {
        SceneManager.LoadScene(10);
    }

    public void Back_HutanAkhir() //tombol 'Back' pada scene hutan akhir
    {
        SceneManager.LoadScene(7);
    }

    public void Selesai() //tombol 'Selesai' pada scene kota awal&kutub awal
    {
        SceneManager.LoadScene(0);
    }
}
