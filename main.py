todo_list = []


while True:
    secim = input("""
Ne yapmak istersein 
1.Ekle
2.Yap
3.Çıkış
> : """)

    if secim == '1':
        todo_list.append(input("todo girin :"))

    if secim == '2':
        counter = 1
        if len(todo_list) == 0:
            print("todo listeniz boş...")
        else:
            for todo in todo_list:
                print(f"{counter}.{todo}")
                counter += 1

            if hangi_todo := input("hangi todo : "):
                todo_list.pop(int(hangi_todo)-1)

    if secim == '3':
        print("iyi günler ..")
        break

