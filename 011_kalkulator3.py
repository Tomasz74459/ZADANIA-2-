print("""==========
Prosty kalkulator
podaj typ operacji jaką chcesz wykonać
dozwolone operacje: + - * / **
operacja "x" kończy działanie programu
następnie podaj dwie liczny dla których chcesz dokonać obliczeń
==========""")

while True:
    operacja = input("Jaką operację chcesz wykonać? (+, -, *, /, **, x): ")
    if operacja.lower() == 'x':
        print("Do zobaczenia!")
        break
    a = float(input("Podaj liczbę a: "))
    b = float(input("Podaj liczbę b: "))

    if operacja == '+':
        print(str(a) + " + " + str(b) + " = " + str(a+b))
    elif operacja == '-':
        print(str(a) + " - " + str(b) + " = " + str(a-b))
    elif operacja == '*':
        print(str(a) + " * " + str(b) + " = " + str(a*b))
    elif operacja == '/':
        if b == 0:
            print("dzielenie przez 0 jest niedozwolone!")
        else:
            print(str(a) + " / " + str(b) + " = " + str(a/b))
    elif operacja == '**':
        print(str(a) + " ** " + str(b) + " = " + str(a**b))
    else:
        print("nie umiem wykonać operacji \"" + operacja + "\" :(")
