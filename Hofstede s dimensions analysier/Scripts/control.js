statusperson = false;
filialflag = false;
facultyon = false;
facultyfilial = 0;
facultyflag= false;
countrybrflag = false;
countrylivflag = false;
previousitem = "";
podtvergden = false;


var statusznach = new Array();
	statusznach[0] = "Абитуриент НИУ ВШЭ";
	statusznach[1] = "Студент НИУ ВШЭ";
	statusznach[2] = "Преподаватель НИУ ВШЭ";
	statusznach[3] = "Сотрудник НИУ ВШЭ";
	statusznach[4] = "Родитель абитуриента НИУ ВШЭ";
	statusznach[5] = "Родитель студента НИУ ВШЭ";
var filialznach = new Array();
	filialznach[0] = "Москва";
	filialznach[1] = "МИЭМ";
	filialznach[2] = "Нижний Новгород";
	filialznach[3] = "Пермь";
	filialznach[4] = "Санкт-Петербург";
var facultyznach = new Array(); //осторожно, зависит от верхнего

for(var i=0; i<5; i++){
    facultyznach[i] = new Array();
}

facultyznach[0][0] = "Факультет истории";
facultyznach[0][1] = "Факультет медиакоммуникаций";
facultyznach[0][2] = "Факультет мировой экономики и мировой политики";
facultyznach[0][3] = "Факультет прикладной политологии";
facultyznach[0][4] = "Отделение интегрированных коммуникаций";
facultyznach[0][5] = "Факультет психологии";
facultyznach[0][6] = "Факультет социологии";
facultyznach[0][7] = "Факультет филологии";
facultyznach[0][8] = "Факультет философии";
facultyznach[0][9] = "Отделение востоковедения";
facultyznach[0][10] = "Отделение культурологии";
facultyznach[0][11] = "Факультет дизайна";
facultyznach[0][12] = "Факультет бизнес-информатики";
facultyznach[0][13] = "Факультет государственного и муниципального управления";
facultyznach[0][14] = "Факультет логистики";
facultyznach[0][15] = "Факультет менеджмента";
facultyznach[0][16] = "Факультет экономики";
facultyznach[0][17] = "Отделение статистики, анализа данных и демографии";
facultyznach[0][18] = "Совместный бакалавриат ВШЭ и РЭШ";
facultyznach[0][19] = "Международный институт экономики и финансов";
facultyznach[0][20] = "Отделение прикладной математики и информатики";
facultyznach[0][21] = "Отделение программной инженерии";
facultyznach[0][22] = "Факультет математики";
facultyznach[0][23] = "Факультет филологии";


facultyznach[1][0] = "Факультет информационных технологий и вычислительной техники";
facultyznach[1][1] = "Факультет прикладной математики и кибернетики";
facultyznach[1][2] = "Факультет электроники и телекоммуникаций";

facultyznach[2][0] = "Факультет гуманитарных наук";
facultyznach[2][1] = "Факультет права";
facultyznach[2][2] = "Факультет истории";
facultyznach[2][3] = "Факультет бизнес-информатики и прикладной математики";
facultyznach[2][4] = "Факультет менеджмента";
facultyznach[2][5] = "Факультет экономики";

facultyznach[3][0] = "Факультет бизнес-информатики";
facultyznach[3][1] = "Социально-гуманитарный факультет";
facultyznach[3][2] = "Факультет менеджмента";
facultyznach[3][3] = "Факультет экономики";

facultyznach[4][0] = "Факультет социологии";
facultyznach[4][1] = "Юридический факультет";
facultyznach[4][2] = "Отделение прикладной политологии";
facultyznach[4][3] = "Факультет истории";
facultyznach[4][4] = "Факультет менеджмента";
facultyznach[4][5] = "Факультет экономики";

 var countrieslist = new Array();
	countrieslist[0] = "Австралия";
	countrieslist[1] = "Австрия";
	countrieslist[2] = "Азербайджан";
	countrieslist[3] = "Алжир";
	countrieslist[4] = "Ангола";
	countrieslist[5] = "Андорра";
	countrieslist[6] = "Антигуа и Барбуда";
	countrieslist[7] = "Аргентина";
	countrieslist[8] = "Армения";
	countrieslist[9] = "Афганистан";
	countrieslist[10] = "Багамские Острова";
	countrieslist[11] = "Бангладеш";
	countrieslist[12] = "Барбадос";
	countrieslist[13] = "Бахрейн";
	countrieslist[14] = "Беларусь";
	countrieslist[15] = "Белиз";
	countrieslist[16] = "Бельгия";
	countrieslist[17] = "Бенин";
	countrieslist[18] = "Болгария";
	countrieslist[19] = "Боливия";
	countrieslist[20] = "Босния и Герцеговина";
	countrieslist[21] = "Ботсвана";
	countrieslist[22] = "Бразилия";
	countrieslist[23] = "Бруней";
	countrieslist[24] = "Буркина-Фасо";
	countrieslist[25] = "Бурунди";
	countrieslist[26] = "Бутан";
	countrieslist[27] = "Вануату";
	countrieslist[28] = "Ватикан";
	countrieslist[29] = "Великобритания";
	countrieslist[30] = "Венгрия";
	countrieslist[31] = "Венесуэла";
	countrieslist[32] = "Вьетнам";
	countrieslist[33] = "Габон";
	countrieslist[34] = "Гаити";
	countrieslist[35] = "Гайана";
	countrieslist[36] = "Гамбия";
	countrieslist[37] = "Гана";
	countrieslist[38] = "Гватемала";
	countrieslist[39] = "Гвинея";
	countrieslist[40] = "Германия";
	countrieslist[41] = "Гондурас";
	countrieslist[42] = "Гренада";
	countrieslist[43] = "Греция";
	countrieslist[44] = "Грузия";
	countrieslist[45] = "Дания";
	countrieslist[46] = "Доминиканская Республика";
	countrieslist[47] = "Египет";
	countrieslist[48] = "Замбия";
	countrieslist[49] = "Зимбабве";
	countrieslist[50] = "Израиль";
	countrieslist[51] = "Индия";
	countrieslist[52] = "Индонезия";
	countrieslist[53] = "Иордания";
	countrieslist[54] = "Ирак";
	countrieslist[55] = "Иран";
	countrieslist[56] = "Ирландия";
	countrieslist[57] = "Исландия";
	countrieslist[58] = "Испания";
	countrieslist[59] = "Италия";
    countrieslist[60] = "Йемен";
    countrieslist[61] = "Казахстан";
    countrieslist[62] = "Камбоджа";					
    countrieslist[63] = "Камерун";
    countrieslist[64] = "Канада";
    countrieslist[65] = "Катар";
    countrieslist[66] = "Кения";
    countrieslist[67] = "Кипр";
    countrieslist[68] = "Кирибати";
    countrieslist[69] = "Китай";
    countrieslist[70] = "Колумбия";
    countrieslist[71] = "Коморские Острова";
    countrieslist[72] = "Конго";
    countrieslist[73] = "КНДР";					
    countrieslist[74] = "Коста-Рика";
    countrieslist[75] = "Кот-д'Ивуар";
    countrieslist[76] = "Куба";
    countrieslist[77] = "Кувейт";
    countrieslist[78] = "Кыргызстан";
    countrieslist[79] = "Лаос";
    countrieslist[80] = "Латвия";
    countrieslist[81] = "Лесото";
    countrieslist[82] = "Либерия";
    countrieslist[83] = "Ливан";
    countrieslist[84] = "Ливия";					
    countrieslist[85] = "Литва";
    countrieslist[86] = "Лихтенштейн";
    countrieslist[87] = "Люксембург";
    countrieslist[88] = "Маврикий";
    countrieslist[89] = "Мавритания";
    countrieslist[90] = "Мадагаскар";
    countrieslist[91] = "Македония";
    countrieslist[92] = "Малави";
    countrieslist[93] = "Малайзия";
    countrieslist[94] = "Мали";
    countrieslist[95] = "Мальдивские Острова";
    countrieslist[96] = "Мальта";					
    countrieslist[97] = "Марокко";
    countrieslist[98] = "Маршалловы Острова";
    countrieslist[99] = "Мексика";
    countrieslist[100]="Микронезия";
    countrieslist[101] = "Мозамбик";
    countrieslist[102] = "Молдова";
    countrieslist[103] = "Монако";
    countrieslist[104] = "Монголия";
    countrieslist[105] = "Мьянма";

   
    countrieslist[106] = "Намибия";
    countrieslist[107] = "Науру";
    countrieslist[108] = "Непал";
    countrieslist[109] = "Нигер";
    countrieslist[110] = "Нигерия";
    countrieslist[111] = "Нидерланды";
    countrieslist[112] = "Никарагуа";
    countrieslist[113] = "Новая Зеландия";
    countrieslist[114] = "Норвегия";

    
    countrieslist[115] = "ОАО";
    countrieslist[116] = "Оман";
    countrieslist[117] = "Пакистан";
    countrieslist[118] = "Палау";
    countrieslist[119] = "Панама";
    countrieslist[120] = "Папуа-Новая Гвинея";
    countrieslist[121] = "Парагвай";
    countrieslist[122] = "Перу";
    countrieslist[123] = "Польша";
    countrieslist[124] = "Португалия";

    countrieslist[125] = "Республика Корея";
    countrieslist[126] = "Россия";
    countrieslist[127] = "Руанда";
    countrieslist[128] = "Румыния";

    countrieslist[129] = "Сальвадор";
    countrieslist[130] = "Самоа";
    countrieslist[131] = "Сан-Марино";
    countrieslist[132] = "Саудовская Аравия";
    countrieslist[133] = "Свазиленд";
    countrieslist[134] = "Сейшельские Острова";
    countrieslist[135] = "Сенегал";
    countrieslist[136] = "Сент-Винсент и Гренадины";
    countrieslist[137] = "Сент-Китс и Невис";
    countrieslist[138] = "Сент-Люсия";
    countrieslist[139] = "Сербия*";
    countrieslist[140]= "Сингапур*";
    countrieslist[141] = "Сирия";
    countrieslist[142] = "Словакия";
    countrieslist[143] = "Словения";
    
    countrieslist[144] = "США";
    countrieslist[145] = "Соломоновы Острова";
    countrieslist[146] = "Сомали";
    countrieslist[147] = "Судан";
    countrieslist[148] = "Суринам";
    countrieslist[149] = "Сьерра-Леоне";

    countrieslist[150] = "Таджикистан";
    countrieslist[151] = "Таиланд";
    countrieslist[152] = "Танзания";
    countrieslist[153] = "Тимор-Лешти";
    countrieslist[154] = "Того";
    countrieslist[155] = "Тонга";
    countrieslist[156] = "Тринидад и Тобаго";
    countrieslist[157] = "Тувалу";
    countrieslist[158] = "Тунис";
    countrieslist[159] = "Туркменистан";
    countrieslist[160] = "Турция";
    countrieslist[161] = "Уганда";
    countrieslist[162] = "Узбекистан";
    
    countrieslist[163] = "Украина";
    countrieslist[164] = "Уругвай";
    countrieslist[165] = "Фиджи";
    countrieslist[166] = "Филиппины";
    countrieslist[167] = "Финляндия";
    countrieslist[168] = "Франция";
    countrieslist[169] = "Хорватия";
    countrieslist[170] = "Центральноафриканская Республика";
    countrieslist[171] = "Чад";

    countrieslist[172] = "Черногория*";
    countrieslist[173] = "Чехия";
    countrieslist[174] = "Чили";

    countrieslist[175] = "Швейцария";
    countrieslist[176] = "Швеция";
    countrieslist[177] = "Шри-Ланка";
    countrieslist[178] = "Эквадор";
    countrieslist[179] = "Экваториальная Гвинея";
    countrieslist[180] = "Эритрея";
    countrieslist[181] = "Эстония";
    countrieslist[182] = "Эфиопия";

    countrieslist[183] = "Южная Африка";
    countrieslist[184] = "Южный Судан";
    countrieslist[185] = "Ямайка";
    countrieslist[186] = "Япония";


function hideitem(list) {
	switch (list) {
		case "liststatus":
			$('.liststatus').css("height","0px");
			$(".liststatus").hide();
			statusperson = false;
		break;
		case "filiallist":
			$('.listfilial').css("height","0px");
			$(".listfilial").hide();
			filialflag = false;
			break;
		case "listfaculty":
			$('#listfaculty').css("height","0px");
			$("#listfaculty").hide();
			facultyflag = false;
			break;
		case "listcountryliv":
			$('#listcountryliv').css("height","0px");
			$("#listcountryliv").hide();
			countrylivflag = false;
			break;
		case "listcountrybr":
			$('#listcountrybr').css("height","0px");
			$("#listcountrybr").hide();
			countrybrflag = false;
			break;
		default:
			break;
		}


}


function statusonclick() {
	if(statusperson==false) {

			hideitem(previousitem);
			$('.liststatus').show();
  
			$('.liststatus').animate(
				{height:"+=233px"},500);
			
			previousitem = "liststatus";
			statusperson = true;
	}
}

function statitemclick(numberelement) {
	document.getElementById("statustext").innerHTML = statusznach[numberelement];
	document.getElementById("status").value = numberelement;
	$('#lbstatus').hide();
	//alert(document.getElementById("status").value);

	$('.liststatus').animate(
				{height:"-=233px"},500
				,function(){
					$('.liststatus').hide();
					statusperson = false;
                }
			);	
}


function filialonclick() {
	if(filialflag==false) {
			
			hideitem(previousitem);
			$('.listfilial').show();
  
			$('.listfilial').animate(
				{height:"+=195px"},500);
			filialflag = true;
			
			previousitem = "filiallist";
	}
}

function filialitemclick(numberelement) {
	document.getElementById("filialtext").innerHTML = filialznach[numberelement];
	document.getElementById("filial").value = filialznach[numberelement];
	//alert(document.auto.status.value);
	
	$('#lbfilial').hide();
	document.getElementById("faculty").value = "";
	document.getElementById("facultytext").innerHTML = "Выбирите свой факультет";


	$('#lbfaculty').show();
	$('.listfilial').animate(
				{height:"-=195px"},500
				,function(){
					$('.listfilial').hide();
					filialflag = false;
					facultyon = true;
					facultyfilial = numberelement;
                }
			);	
}

function facultyonclick() {
	if (facultyon==false) {
		alert("Выбирите сначала филиал НИУ ВШЭ");
		filialonclick();
	}
	else {
		hideitem(previousitem);
		document.getElementById("listfaculty").innerHTML ="";
		for (var i = facultyznach[facultyfilial].length - 1; i >= 0; i--) {
					
					document.getElementById("listfaculty").innerHTML +='<div class = "listitem" onclick = "facultyitemclick('+i+')">'+facultyznach[facultyfilial][i]+'</div>';	
		};
		
		switch(facultyfilial){
			case 0:
				$('#listfaculty').show();
				$('#listfaculty').animate(
					{height:"+="+224+"px"},500, function(){
				 		jQuery('#listfaculty').jScrollPane({showArrows: true,
						verticalDragMinHeight: 37,
       	    			verticalDragMaxHeight: 37}); 
       	    			facultyflag = true;
					}
				);
				break;
			case 1:
				$('#listfaculty').show();
				$('#listfaculty').animate(
					{height:"+="+158+"px"},500
				);
				break;
			case 2:
				$('#listfaculty').show();
				$('#listfaculty').animate(
					{height:"+="+244+"px"},500
				);
				break
			case 3:
				$('#listfaculty').show();
				$('#listfaculty').animate(
					{height:"+="+154+"px"},500
				);
				break;
			case 4:
				$('#listfaculty').show();
				$('#listfaculty').animate(
					{height:"+="+230+"px"},500
				);
				break;
			default:
				break;
			}
		previousitem = "listfaculty";

			

			
		
	}
}

function facultyitemclick(numberelement) {
	document.getElementById("facultytext").innerHTML = facultyznach[facultyfilial][numberelement];
	document.getElementById("faculty").value = facultyznach[facultyfilial][numberelement];
	//alert(document.auto.status.value);
	switch(facultyfilial){
			case 0:
			
				$('#listfaculty').animate(
					{height:"-="+224+"px"},500, function() {
						$('#listfaculty').hide();
					}
				);
				break;
			case 1:
		
				$('#listfaculty').animate(
					{height:"-="+158+"px"},500, function() {
						$('#listfaculty').hide();
					}
				);
				break;
			case 2:
		
				$('#listfaculty').animate(
					{height:"-="+244+"px"},500, function() {
						$('#listfaculty').hide();
					}
				);
				break
			case 3:
		
				$('#listfaculty').animate(
					{height:"-="+154+"px"},500, function() {
						$('#listfaculty').hide();
					}
				);
				break;
			case 4:
			
				$('#listfaculty').animate(
					{height:"-="+230+"px"},500, function() {
						$('#listfaculty').hide();
					}
				);
				break;
			default:
				break;
			}
		$("#lbfaculty").hide();
		facultyflag = false;


}








function countrybronclick() {
	if(countrybrflag==false) {
		//alert("ok");
			hideitem(previousitem);
			$('#listcountrybr').show();
  
			$('#listcountrybr').animate(
				{height:"+=230px"},500, function(){
					 jQuery('#listcountrybr').jScrollPane({showArrows: true,
						verticalDragMinHeight: 37,
       	    			verticalDragMaxHeight: 37}); facultyflag = true;
				});
			countrybrflag = true;
			previousitem = "listcountrybr";
	}
}

function countrybritemclick(numberelement) {
	document.getElementById("countrybrtext").innerHTML = countrieslist[numberelement];
	document.getElementById("countrybr").value = countrieslist[numberelement];
	$('#lbcountrybr').hide();

	$('#listcountrybr').animate(
				{height:"-=230px"},500
				,function(){
					$('#listcountrybr').hide();
					countrybrflag = false;
                }
			);	
}

function countrylivonclick() {
	if(countrylivflag==false) {
			hideitem(previousitem);
			$('#listcountryliv').show();
  
			$('#listcountryliv').animate(
				{height:"+=230px"},500, function(){
					 jQuery('#listcountryliv').jScrollPane({showArrows: true,
						verticalDragMinHeight: 37,
       	    			verticalDragMaxHeight: 37}); facultyflag = true;
				});
			countrylivflag = true;
			previousitem = "listcountryliv";
	}
}

function countrylivitemclick(numberelement) {
	document.getElementById("countrylivtext").innerHTML = countrieslist[numberelement];
	document.getElementById("countryliv").value = countrieslist[numberelement];
	$('#lbcountryliv').hide();

	$('#listcountryliv').animate(
				{height:"-=230px"},500
				,function(){
					$('#listcountryliv').hide();
					countrylivflag = false;
                }
			);	
}

function buttonpodv() {
	if (podtvergden ==false) {
		document.getElementById("submitpodtv").src = "Styles/vkl.png";
		podtvergden = true;
	}else{
		document.getElementById("submitpodtv").src = "Styles/vykl.png";
		podtvergden = false; 
	}

}


function addcountriees() {
	for (var i = 0; i <= (countrieslist.length - 1); i++) {
		document.getElementById("listcountrybr").innerHTML +='<div class = "listitem" onclick = " countrybritemclick('+i+')">'+countrieslist[i]+'</div>';
		document.getElementById("listcountryliv").innerHTML +='<div class = "listitem" onclick = " countrylivitemclick('+i+')">'+countrieslist[i]+'</div>';
		
	};
}



function submitclick() {
		if (document.getElementById("status").value == "") {
				alert("Вы не ввели ваш статус относительно НИУ ВШЭ");
				statusonclick();
		}else{
			if (document.getElementById("filial").value == "") {
				alert("Вы не выбрали ваш филиал");			
				filialonclick();
			}else{
				if (document.getElementById("faculty").value == "") {
					alert("Вы не выбрали ваш факультет");			
					facultyonclick();
				}else{
					if (document.getElementById("countrybr").value == "") {
						alert("Вы не выбрали вашу родную страну");			
						countrybronclick();
					}else{
						if (document.getElementById("countryliv").value == "") {
							alert("Вы не выбрали вашу страну проживания");			
							countrylivonclick();
						}else{
							if (podtvergden == false) {
								alert("Вы не подтвердили разрешение на хранение и обработку ваших данных");			
							}else{
								document.getElementById("auto").submit();		
							}				
						}				
					}					
				}				
			}			
		}

	
}