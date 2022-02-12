from tkinter import *
from tkinter.font import *
from tkinter import filedialog
from tkinter import scrolledtext
from PIL import Image, ImageTk
class Interfaz(Tk):
    def __init__(self):
        super().__init__()
        #configuracion de la ventana de inicio
        self.title("Proyecto de Compiladores")
        self.iconbitmap("./Recursos/icono.ico")
        #filas y columnas
        self.rowconfigure(0, minsize=400, weight=1)
        self.columnconfigure(0, minsize=400, weight=1)
        self.__icon_Open = None
        self.__icon_Close = None
        # Atributo de archivo
        self.archivo = None
        # Atributo para saber si ya se abrió un archivo anteriormente
        self.archivo_abierto = False
        #Fuente
        self.FuenteCuadroTexto = Font(
            family="Consolas",
            size=12,
        )
        #cuadro de texto
        self.campo_texto = scrolledtext.ScrolledText(self, wrap=WORD)
        #crear los componentes
        self._crearComponentes()
        #crear iconos menu
        self._crearIconos()
        #crear los menus
        self._crearMenu()

    def _crearComponentes(self):
        #Frame Principal
        framePrincipal = Frame(self)
        #configuracion disenio
        framePrincipal.config(width=500,
                              height=500,
                              borderwidth=3,
                              relief='sunken')
        framePrincipal.grid(row=0, column=0, sticky='NSEW')
        #configuracion del frame
        framePrincipal.rowconfigure(0, minsize=400, weight=1)
        framePrincipal.columnconfigure(0, minsize=400, weight=1)
        #colocacion del campo de texto
        # Atributo de campo de texto
        self.campo_texto = scrolledtext.ScrolledText(framePrincipal, wrap = WORD)
        self.campo_texto.grid(row=0,column=0,sticky='NSEW')
        self.campo_texto.config(font=self.FuenteCuadroTexto)

    def _crearMenu(self):
        # Creamos el menu
        menu_Principal = Menu(self)
        self.config(menu=menu_Principal)

        # menu archivo
        menu_archivo = Menu(menu_Principal, tearoff=False)
        menu_Principal.add_cascade(label='Archivo', menu=menu_archivo)
        # opciones menu archivo
        menu_archivo.add_command(label='Abrir',image=self.__icon_Open,compound=LEFT,command=lambda :self.abrirArchivo())
        menu_archivo.add_separator()
        menu_archivo.add_command(label='Salir',image=self.__icon_Close,compound=LEFT, command=self.quit)


    def abrirArchivo(self):
        self.archivo_abierto = filedialog.askopenfilename(title="Abrir",
                                          initialdir="C:\\Users\\rodri\\\Documents\\GitHub\\Python\\Clase\\"
                                          , filetypes=(("Archivos de texto", ".txt"), ("Todos los Archivos", ".*")))

        with open(self.archivo_abierto, "r") as archivoSeleccionado:
            texto = ""
            for linea in archivoSeleccionado:
                texto += linea

        # Colocar el nombre del archivo en el titulo de la ventana
        rutaSplit = self.archivo_abierto.split("/")
        nombreArchivo = rutaSplit[len(rutaSplit) - 1]
        self.title(f'Proyecto Compiladores - {nombreArchivo}')
        #Limpiar cuadro de texto
        self.campo_texto.delete(1.0,END)
        # colocar el texto del archivo en nuestro cuadro de texto
        self.campo_texto.insert(1.0,texto)

    def _crearIconos(self):
        #Abrir
        __iconOpen = Image.open('./Recursos/icon_open.png')
        __iconRedimensionadoOpen = __iconOpen.resize((20, 20))
        self.__icon_Open = ImageTk.PhotoImage(__iconRedimensionadoOpen)
        # Cerrar
        __iconClose = Image.open('./Recursos/icon_close.png')
        __iconRedimensionadoClose = __iconClose.resize((20, 20))
        self.__icon_Close = ImageTk.PhotoImage(__iconRedimensionadoClose)


if __name__ == '__main__':
    interfaz = Interfaz()
    interfaz.mainloop()