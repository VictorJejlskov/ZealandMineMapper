interface IVATCalculator{
    calculate(amount: number): number
}
class VATCalculator implements IVATCalculator{
    calculate(amount: number): number {
        return amount * 1.25
    }
}
const vat: VATCalculator = new VATCalculator()
console.log(vat.calculate(100))