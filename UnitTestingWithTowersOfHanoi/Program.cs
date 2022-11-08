/*
 * Tårnene i Hanoi-spillet består av tre
 * pinner og en rekke runde skiver med et hull
 * i midten. Skivene er av varierende bredde,
 * og kan plasseres i en hvilken som helst av
 * de tre pinnene. Puslespillet starter med
 * alle diskene plasserte over en pinne,
 * ordnet etter størrelse, med den minste
 * øverst, slik at de danner en konisk form.
 *
 * Puslespillet går ut på å flytte alle skivene
 * til en annen pinne, etter følgende regler:
 *  - Bare én skive av gangen kan flyttes.
 *  - Den øverste skiven flyttes fra en av
 *    pinnene til en annen pinne, på toppen av
 *    andre skiver som allerede kan være på den
 *    andre pinnen.
 *  - Ingen skive kan plasseres over en mindre
 *    skive.
 * https://no.wikipedia.org/wiki/T%C3%A5rnet_i_Hanoi
 *
 * Unit testing
 *  - Teste klasser vs teste funksjoner (som i M1): tilstand!
 *  - Korrekthet og kvalitet, unit testene er mine soldater som forsvarer min kode
 *  - Unit testing som en måte å forstå objektorientering på
 *  - Testdrevet utvikling
 *  - Test coverage
 *  - Automatisk testing: CI - Continous Integration
 *
 */

using UnitTestingWithTowersOfHanoi;

var game = new TowerOfHanoiGame();
Console.WriteLine(game.GetText());
game.Move(0, 1);
Console.WriteLine(game.GetText());
