using System;
using System.Collections.Generic;
using System.Text;

namespace CampGenaricsIntro
{
    class MyList<T>//MyListimde T ile çalışıcam anlamına geliyor.Kullanıcı hangi tipi kullanmak isterse(T)
    {

        T[] items;//Classın içinde oluşturulduğu için tüm metodlar erişebilir.
        public MyList()//(ctor) buna constructor denir. classı newlersen bu otomatik çalışır.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//burda önceki arrayın referanss numarası uçmasın diye tutturduk.
            items = new T[items.Length + 1];//dizinin eleman sayısını bir arttır demek.(Length : uzunluk)
            //new diyince referans numaran sıfırlanır(adres)bu yüzden numarayı birine tutturmamız gerek(tempArray)
            for (int i = 0; i < tempArray.Length; i++)//tempArrayde silinmesin diye tuttuğumuz elemanları itemse geri atayacağız.
            {
                items[i] = tempArray[i];//yeniden itemse geri aldık
            }

            items[items.Length - 1] = item;//en başta eklenmek istenen elemanı şimdi son elemana eklemiş oluyorsun.
        }

    }
}
